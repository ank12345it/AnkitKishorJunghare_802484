using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training.Models
{
    public class Training
    {
        [Key]
        public long Training_id { get; set; }
        public long User_id { get; set; }

        public long Mentor_id { get; set; }

        public long Skill_id { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string Mentor_From_Timeslot { get; set; }
        public string Mentor_To_Timeslot { get; set; }
        public string Training_Status { get; set; }
        public long Training_Progress { get; set; }
        public long rating { get; set; }



        
    }
}
