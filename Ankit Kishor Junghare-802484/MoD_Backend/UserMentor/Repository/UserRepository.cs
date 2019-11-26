using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMentor.Models;
using UserMentor.Context;
using Microsoft.EntityFrameworkCore;

namespace UserMentor.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserMentorContext _context;
        public UserRepository(UserMentorContext Context)
        {
            _context = Context;

        }
        public void User_Add(User item)
        {
            _context.User.Add(item);
            _context.SaveChanges();

        }

        public void User_Block(long id)
        {
            var item = _context.User.Find(id);
            item.User_active = !(item.User_active);
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public int User_Block_status(long id)
        {
            var item = _context.User.Find(id);
            if (item.User_active == true)
            { return 1; }
            else
               return 0;
        }

        public void User_Delete(long id)
        {
            var item = _context.User.Find(id);
            _context.User.Remove(item);
            _context.SaveChanges();

        }

        public List<User> User_GetAll()
        {
            return _context.User.ToList();
        }

       

        public void User_Up_password(string email,string pass)
        {
            var item = _context.User.SingleOrDefault(i => i.User_Email == email);
            item.User_Password = pass;
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

        }

        public List<Mentor> User_Search_Mentor(string skills, string from_timeslot,string to_timeslot)
        {
           // return _context.Mentor.Where(i =>i.Mentor_PrimarySkill == skills && i.Mentor_From_TimeSlot == from_timeslot && i.Mentor_To_TimeSlot = to_timeslot)).ToList();
            return (from f in _context.Mentor where
                    f.Mentor_PrimarySkill == skills &&
                    f.Mentor_From_TimeSlot == from_timeslot &&
                    f.Mentor_To_TimeSlot == to_timeslot select f).ToList();

        }
    }
}
