using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMentor.Models;

namespace UserMentor.Repository
{
    public interface IUserRepository
    {
        void User_Add(User item);
        List<User> User_GetAll();

        List<Mentor> User_Search_Mentor(string skill,string from_timeslot,string to_timeslot);
        //void User_Update(User item);
        void User_Delete(long id);
        void User_Up_password(string email,string pass);
        void User_Block(long id);
        public int User_Block_status(long id);
        
    }
}
