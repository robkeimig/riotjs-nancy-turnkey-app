using System.Threading.Tasks;
using Nancy;
using Microsoft.EntityFrameworkCore;
using NancyApplication.Model;
using NancyApplication.Services;
using Nancy.ModelBinding;
using NancyApplication.Data;

namespace NancyApplication.Controllers
{
    public class UserController : NancyModule
    {
        private static readonly DbContextOptions<DataContext> DbOptions;

        static UserController()
        {
            //For the love of god need some DI in here lol
            DbOptions = new DbContextOptionsBuilder<DataContext>()
               .UseInMemoryDatabase(databaseName: "UserDatabase")
               .Options;
        }

        public UserController() : base("Api")
        {
            Get("User", async (_, ct) => await GetAllUsersAsync());
            Post("User", async (_, ct) => await AddUserAsync());
        }

        private async Task<Response> AddUserAsync()
        {
            var user = this.Bind<User>();

            using (var ctx = new DataContext(DbOptions))
            {
                var userService = new UserService(ctx);
                await userService.AddAsync(user).ConfigureAwait(false);
            }

            return 200;
        }

        //http://semantic-ui.com/usage/layout.html

        private async Task<Response> GetAllUsersAsync()
        {
            using (var ctx = new DataContext(DbOptions))
            {
                var userService = new UserService(ctx);
                return Response.AsJson(userService.GetAll());
            }
        }
    }
}