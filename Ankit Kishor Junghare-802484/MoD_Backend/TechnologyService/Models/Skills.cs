using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnologyService.Models
{
    public class Skills
    {
        [Key]
        public long Skill_Id { get; set; }
        public string Skill_Name { get; set; }
        public string Skill_Toc { get; set; }
        public double Skill_Fee { get; set; }
        public int Skill_Duration { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
    }
}
