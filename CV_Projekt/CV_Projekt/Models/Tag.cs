using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class Tag
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "En tagg måste ha ett namn.")]
		public string Descriptor { get; set; }
		public virtual List<User>? Users { get; set; } = new List<User>();
	}
}
