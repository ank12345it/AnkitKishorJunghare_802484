using AuthenticateService.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Models;

namespace AuthenticateService.Repository
{
    public class LoginRepository:ILoginInterface
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext Context)
        {
            _context = Context;
        }
         public User UserLogin(string uEmail, string pwd)
        {
            return _context.User.SingleOrDefault(data => data.User_Email == uEmail && data.User_Password == pwd && data.User_active==true);
            //if (obj != null)
            //    return true;
            //else
            //    return false;
       }

        public Mentor MentorLogin(string mEmail, string pwd)
        {

           return _context.Mentor.SingleOrDefault(data => data.Mentor_Email == mEmail && data.Mentor_Password ==pwd && data.Mentor_active==true);
            //if (obj != null)
            //    return true;
            //else
            //    return false;
        }
    }
}
