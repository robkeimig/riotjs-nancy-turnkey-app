using System.Collections.Generic;
 
namespace NancyApplication.Model
{
    public class User
    {
        public int Id { get; set; }
 
        public string FirstName { get; set; }
 
        public string LastName { get; set; }
 
        public List<Post> Posts { get; set; }
    }
}