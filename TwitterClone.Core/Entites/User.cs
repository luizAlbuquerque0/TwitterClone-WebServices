﻿namespace TwitterClone.Core.Entites
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Posts = new List<Post>();
            CreatedAt = DateTime.Now;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<Post> Posts { get; private set; }
        public List<PostComment> Comments { get; private set; }
        public string? Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string? BirthDate { get; private set; }
        public string? HomeTown { get; private set; }
        public string? Profilepic { get; private set; }

        public void AddDescription(string description)
        {
            Description = description;
        }

        public void AddBirthDate(string birthDate)
        {
            BirthDate = birthDate;
        }

        public void AddHomeTown(string homeTown)
        {
            HomeTown = homeTown;
        }

        public void AddProfilePic(string profilepic)
        {
            Profilepic = profilepic;
        }
    }
}
