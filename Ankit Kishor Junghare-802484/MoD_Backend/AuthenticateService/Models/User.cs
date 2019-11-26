using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticateService.Models
{
    public class User
    {
        [Key]
        public long User_Id { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public string User_Email { get; set; }
        [Required]
        public long User_Mobile { get; set; }
        public string User_Password { get; set; }
        public bool? User_active { get; set; }

    }
}
