namespace CV_Projekt.Models
{
    public class Chat11ViewModel : BaseViewModel
    {
        public List<Message> AllMessages { get; set; }
        public User LoggedInUser { get; set; }
        public User OtherUser { get; set; }

        public Chat11ViewModel() : base() { }
        public Chat11ViewModel(CvContext context, string id) : base(context, id) { }
    }
}
