using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMentor.Models;

namespace UserMentor.Context
{
    public class UserMentorContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Training> Training { get; set; }
        public UserMentorContext(DbContextOptions<UserMentorContext> options) : base(options) { }
    }
}
