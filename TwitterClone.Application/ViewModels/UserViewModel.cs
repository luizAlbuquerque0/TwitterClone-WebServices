namespace TwitterClone.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email,string createdAt, string birthDate, string homeTown, string description, string profilePic)
        {
            FullName = fullName;
            Email = email;
            CreatedAt = createdAt;
            BirthDate = birthDate;
            HomeTown = homeTown;
            Description = description;
            ProfilePic = profilePic;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string CreatedAt { get; private set; }
        public string BirthDate { get; private set; }
        public string HomeTown { get; private set; }
        public string Description { get; private set; }
        public string ProfilePic { get; private set; }



    }
}
