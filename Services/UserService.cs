using System.Collections.Generic;
using System.Linq;
using NancyApplication.Model;
using System.Threading.Tasks;

namespace NancyApplication.Services
{
    public class UserService
    {
        private ModelContext _context;

        public UserService(ModelContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
