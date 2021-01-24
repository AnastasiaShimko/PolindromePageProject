using System.Data.Linq.Mapping;

namespace LoginPageProject.Data.Models
{
    [Table(Name = "Users")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "login")]
        public string UserName { get; set; }
        [Column(Name = "password")]
        public string Password { get; set; }
        [Column(Name = "role")]
        public string Role { get; set; }
    }
}
