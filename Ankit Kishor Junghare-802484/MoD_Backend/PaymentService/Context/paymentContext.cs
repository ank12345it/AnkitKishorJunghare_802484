using Microsoft.EntityFrameworkCore;
using PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Context
{
    public class paymentContext
    {

        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Training> Training { get; set; }
        //public paymentContext(DbContextOptions<paymentContext> options) : base(options) { }
    }
}
