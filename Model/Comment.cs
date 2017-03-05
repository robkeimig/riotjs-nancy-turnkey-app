using System;

namespace NancyApplication.Model
{
    public class Comment
    {
        public Int64 Id { get; set; }

        public User User { get; set; }

        public Post ParentPost { get; set; }

        public Comment ParentComment { get; set; }

        public string Content { get; set; }
    }
}
