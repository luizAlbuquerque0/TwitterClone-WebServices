﻿namespace TwitterClone.Core.Entites
{
    public class User : BaseEntity
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<Post> Posts { get; private set; }
        public List<PostComment> Comments { get; private set; }

    }
}
