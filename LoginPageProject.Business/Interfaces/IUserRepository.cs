using LoginPageProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginPageProject.Data.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(string username, string password);
    }
}
