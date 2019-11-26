using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingService.Models
{
    
        public class Payment
        {
            [Key]
            public long Payment_Id { get; set; }

        [ForeignKey("User")]
        public long User_Id { get; set; }

        [ForeignKey("Mentor")]
        public long Mentor_Id { get; set; }

        [ForeignKey("Training")]
        public long Training_Id { get; set; }
            [Required]
            public double Payment_Amount { get; set; }
            [Required]
            public string Skill_Name { get; set; }
            [Required]
            public double Mentor_Amount { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Training Training { get; set; }
        }
    
}
