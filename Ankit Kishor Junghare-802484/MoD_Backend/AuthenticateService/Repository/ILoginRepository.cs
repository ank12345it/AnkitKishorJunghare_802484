using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Models;

namespace AuthenticateService.Repository
{
   public interface ILoginInterface
    {
        User UserLogin(string uEmail, string pwd);
        Mentor MentorLogin(string mEmail, string pwd);
    }
}
