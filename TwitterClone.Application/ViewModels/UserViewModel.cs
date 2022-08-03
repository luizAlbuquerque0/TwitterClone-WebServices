namespace TwitterClone.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email, DateTime createdAt, string birthDate, string homeTown, string description)
        {
            FullName = fullName;
            Email = email;
            CreatedAt = createdAt;
            BirthDate = birthDate;
            HomeTown = homeTown;
            Description = description;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string BirthDate { get; private set; }
        public string HomeTown { get; private set; }
        public string Description { get; private set; }

    }
}
