using System.Linq;
using LoginPageProject.Data;
using LoginPageProject.Data.Interfaces;
using LoginPageProject.Data.Models;

namespace LoginPageProject.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UsersContext db;

        public UserRepository(UsersContext context)
        {
            db = context;
        }
        public User GetUser(string username, string password)
        {
            var result = new User();
            try
            {
                User user = db.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
                result = user;
            }
            catch
            {
                result = null;
            }

            return result;
        }
    }
}
