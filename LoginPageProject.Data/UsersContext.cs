using System;
using System.Collections.Generic;
using System.Text;
using LoginPageProject.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginPageProject.Data
{
    public class UsersContext : DbContext
    { 
        public DbSet<User> Users { get; set; }
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
