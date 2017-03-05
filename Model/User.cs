using System;
using System.Collections.Generic;
 
namespace NancyApplication.Model
{
    public class User
    {
        public Int64 Id { get; set; }
 
        public string Username { get; set; }
 
        public string Email { get; set; }
 
        public IList<Post> Posts { get; set; }
    }
}