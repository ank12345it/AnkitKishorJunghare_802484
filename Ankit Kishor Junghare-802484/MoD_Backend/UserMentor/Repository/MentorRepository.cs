using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMentor.Context;
using UserMentor.Models;

namespace UserMentor.Repository
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserMentorContext _context;

        public MentorRepository(UserMentorContext Context)
        {
            _context = Context;
        }



        public void Mentor_Add(Mentor item)
        {
            _context.Mentor.Add(item);
            _context.SaveChanges();

        }

        public void Mentor_Delete(long id)
        {
            var item = _context.Mentor.Find(id);
            _context.Mentor.Remove(item);
            _context.SaveChanges();

        }

        public List<Mentor> Mentor_GetAll()
        {
            return _context.Mentor.ToList();
        }

        public void Mentor_Update(Mentor item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            
            _context.SaveChanges();

        }
        public void Mentor_Block(long id)
        {
            var item = _context.Mentor.Find(id);
            item.Mentor_active =!(item.Mentor_active);
            //_context.Update(item);
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            //_context.Entry(id).Property(x => x.Mentor_active).IsModified = true;
        }


    }
}
