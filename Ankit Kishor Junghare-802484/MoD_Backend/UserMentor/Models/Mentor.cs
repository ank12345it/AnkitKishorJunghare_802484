using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserMentor.Models
{
    public class Mentor
    {
        [Key]
        public long Mentor_Id { get; set; }
        [Required]
        public string Mentor_Name { get; set; }
        [Required]
        public long Mentor_Mobile { get; set; }
        [Required]
        public string Mentor_Email { get; set; }
        [Required]
        public string Mentor_Password { get; set; }
        [Required]
        public string Mentor_Exp { get; set; }
        [Required]
        public string Mentor_PrimarySkill { get; set; }
        public string Mentor_From_TimeSlot { get; set; }

        public string  Mentor_To_TimeSlot { get; set; }
        public bool? Mentor_Availability { get; set; }
        public bool? Mentor_active { get; set; }
        public IEnumerable<Payment> Payment { get; set; }
        public IEnumerable<Training> Training { get; set; }

    }
}
