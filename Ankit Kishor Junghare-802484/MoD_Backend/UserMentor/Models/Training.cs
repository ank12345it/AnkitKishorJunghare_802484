using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserMentor.Models
{
    public class Training
    {
        
            [Key]
            public long Training_Id { get; set; }
        [ForeignKey("User")]
        public long User_Id { get; set; }
        [ForeignKey("Mentor")]

        public long Mentor_Id { get; set; }
        [ForeignKey("Skills")]
        public long Skill_Id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "Date")]
        public DateTime EndTime { get; set; }

        public string Mentor_From_TimeSlot { get; set; }
            public string Mentor_To_TimeSlot { get; set; }
            public string Training_Status { get; set; }
            public long Training_Progress { get; set; }
            public long rating { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Skills Skills { get; set; }
       public IEnumerable<Payment>  Payment { get; set; }







    }

}
