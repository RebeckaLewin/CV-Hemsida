using Castle.DynamicProxy;
using CV_Projekt.Models;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using System.Xml.Serialization;

namespace CV_Projekt.Controllers
{
    public class ProfileController : Controller
    {
        private CvContext _context;

        public ProfileController(CvContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Profile(string id)
        {
			var loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			ProfileViewModel viewModel = new ProfileViewModel(_context, loggedInId);
			viewModel.User = _context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();
			viewModel.Projects = _context.Projects.ToList();
            viewModel.Tags = _context.Tags.ToList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult FindFriend(string id)
        {
            // sätter upp en tom variabel för att hålla id från en matchad user
            string suitableUserId = "";
            
            User user = _context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();
            List<int> tagIds = new List<int>(); //sätter upp en ny lista för att lagra tagId från taggarna för inloggad user 
            foreach(var tag in user.Tags)   
            {
                tagIds.Add(tag.Id);
            }
            //hämtar users som har taggar med matchande tagId som de som finns i liston ovanför. Exkluderar inaktiva users
            var usersWithMatchingTags = _context.Users
                                               .Include(u => u.Tags)
                                               .Where(u => u.isActive
                                                     && !u.Id.Equals(user.Id)
                                                     && u.Tags.Any(t => tagIds.Contains(t.Id)))
                                               .Select(u => u)
                                               .ToList();
            //om det finns minst en användare i listan så väljs den första, annars kommer man tillbaka till sitt eget cv
            if(usersWithMatchingTags.Count > 0)
            {
				suitableUserId = usersWithMatchingTags.FirstOrDefault().Id;
			}
            else
            {
                suitableUserId = user.Id;
            }

			return RedirectToAction("Profile", new { id = suitableUserId });
        }

        public IActionResult Download()
        {
            /*
                Laddar ner profilen som en xml-fil
                Hämtar in proxies och kopierar över datan till faktiska objekt
            */

			string loggedInId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            User user = _context.Users.Where(u => u.Id.Equals(loggedInId)).FirstOrDefault();

            ProfileInformation profile = new ProfileInformation();
            profile.FullName = user.FirstName + " " + user.LastName;
            profile.Email = user.Email;
            profile.Address = user.ContactInformation.Address;
            profile.Phone = user.ContactInformation.Phone;

            foreach(var project in user.CreatedProjects)
            {
                Project projectToAdd = new Project();
                projectToAdd.Id = project.Id;
                projectToAdd.CreatorId = project.CreatorId;
                projectToAdd.Title = project.Title;
                projectToAdd.Description = project.Description;
                projectToAdd.StartDate = project.StartDate;
                projectToAdd.EndDate = project.EndDate;
                profile.CreatedProjects.Add(projectToAdd);
            }

			foreach (var project in user.JoinedProjects)
			{
				Project projectToAdd = new Project();
				projectToAdd.Id = project.Id;
				projectToAdd.CreatorId = project.CreatorId;
				projectToAdd.Title = project.Title;
				projectToAdd.Description = project.Description;
				projectToAdd.StartDate = project.StartDate;
				projectToAdd.EndDate = project.EndDate;
				profile.JoinedProjects.Add(projectToAdd);
			}

            CV profileCv = new CV();
            CV cv = _context.CVs.Where(cv => cv.OwnerId.Equals(user.Id)).FirstOrDefault();

            profileCv.Id = cv.Id;
            profileCv.OwnerId = cv.OwnerId;
            profileCv.Views = cv.Views;
            foreach(var skill in cv.Skills)
            {
                profileCv.Skills.Add(skill);
			}

            profile.Cv = profileCv;

            List<Work> workList = new List<Work>();
            var work = _context.Experiences.Where(e => e.CvId == profileCv.Id && e is Work);
            foreach(Work w in work)
            {
                Work newWork = new Work();
                newWork.Id = w.Id;
                newWork.CvId = w.CvId;
                newWork.Role = w.Role;
                newWork.Location = w.Location;
                newWork.City = w.City;
                newWork.Description = w.Description;
                newWork.StartDate = w.StartDate;
                newWork.EndDate = w.EndDate;
                workList.Add(newWork);
            }
            profile.Work = workList;

			List<Education> eduList = new List<Education>();
			var edu = _context.Experiences.Where(e => e.CvId == profileCv.Id && e is Education);
			foreach (Education e in edu)
			{
				Education newEdu = new Education();
				newEdu.Id = e.Id;
				newEdu.CvId = e.CvId;
				newEdu.Level = e.Level;
                newEdu.Program = e.Program;
				newEdu.Location = e.Location;
				newEdu.City = e.City;
				newEdu.Description = e.Description;
				newEdu.StartDate = e.StartDate;
				newEdu.EndDate = e.EndDate;
				eduList.Add(newEdu);
			}
            profile.Education = eduList;  

            List<OtherExperience> otherList = new List<OtherExperience>();
            var other = _context.Experiences.Where(e => e.CvId == profileCv.Id && e is OtherExperience);
            foreach(OtherExperience o in other)
            {
                OtherExperience newOther = new OtherExperience();
				newOther.Id = o.Id;
				newOther.CvId = o.CvId;
                newOther.Type = o.Type;
				newOther.Location = o.Location;
				newOther.City = o.City;
				newOther.Description = o.Description;
				newOther.StartDate = o.StartDate;
				newOther.EndDate = o.EndDate;
			}
            profile.OtherExperience = otherList;

			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(ProfileInformation));
				using (var file = new FileStream(user.Id + ".xml", FileMode.Create, FileAccess.Write))
				{
					serializer.Serialize(file, profile);
                    System.Net.Mime.ContentDisposition cd = new System.Net.Mime.ContentDisposition()
                    {
                        FileName = file.Name,
                        Inline = true
                    };
                    Response.Headers.Append("Content-Disposition", $"attachment; filename = {profile.FullName}.xml");
				}
			}
			catch (Exception e)
			{
                Debug.WriteLine(e.Message);
				throw;
			}
			return File(System.IO.File.ReadAllBytes($"{user.Id}.xml"), "application/xml");
        }
	}
}
