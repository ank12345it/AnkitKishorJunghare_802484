using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticateService.Models
{
    public class Token
    {
        public string token { get; set; }
        public string message { get; set; }
        public long user_id { get; set; }
        
    }
}
