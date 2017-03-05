using System.Collections.Generic;
using System.Linq;
using NancyApplication.Model;
using System.Threading.Tasks;
using NancyApplication.Data;

namespace NancyApplication.Services
{
    public class UserService
    {
        private DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            _context.UserEntries.Add(user);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.UserEntries.ToList();
        }
    }
}
