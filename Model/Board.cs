using System.Collections.Generic;

namespace NancyApplication.Model
{
    public class Board
    {
        public string Name { get; set; }

        public IList<Post> Posts { get; set; }

        public IList<User> Moderators { get; set; }
    }
}
