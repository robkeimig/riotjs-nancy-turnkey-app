namespace NancyApplication.Model
{
    public class Post
    {
        public int Id { get; set; }
 
        public string UserId { get; set; }
 
        public User User { get; set; }
 
        public string Content { get; set; }
    }
}