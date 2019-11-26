using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TrainingService.Models;

namespace TrainingService.Context
{
    public class TrainingContext:DbContext
    {

        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Training> Training { get; set; }
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options) { }

    }
}
