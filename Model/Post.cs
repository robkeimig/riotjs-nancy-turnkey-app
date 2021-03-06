using System;

namespace NancyApplication.Model
{
    public class Post
    {
        public Int64 Id { get; set; }
  
        public User User { get; set; }

        public int Approves { get; set; }

        public int Disapproves { get; set; }
 
        public string Content { get; set; }
    }
}