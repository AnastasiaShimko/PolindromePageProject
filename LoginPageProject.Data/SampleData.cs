using LoginPageProject.Data.Models;

namespace LoginPageProject.Data
{
    public static class SampleData
    {
        /// <param name="context"></param>
        public static void Initialize(UsersContext context)
        {
            var testuser = new User()
            {
                UserName = "TestUser",
                Password = "123",
                Role = "User"
            };
            context.Users.AddRange(testuser);
            context.SaveChanges();
        }
    }
}
