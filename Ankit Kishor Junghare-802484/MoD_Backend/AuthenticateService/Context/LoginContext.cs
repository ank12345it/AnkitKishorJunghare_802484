using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Models;

namespace AuthenticateService.Context
{
    public class LoginContext:DbContext

    {
        public LoginContext(DbContextOptions<LoginContext> options):base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
    }
}
