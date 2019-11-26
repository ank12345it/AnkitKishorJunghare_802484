using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnologyService.Models;
using TechnologyService.Context;


namespace TechnologyService.Repository
{
    public class SkillsRepository : ISkillsRepository
    {
        public readonly SkillsContext _context;
        public SkillsRepository(SkillsContext Context)
        {
            _context = Context;
        }
        public void Skills_Add(Skills item)
        {
            _context.Skills.Add(item);
            _context.SaveChanges();
        }

        public void Skills_Update(Skills item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }

        public List<Skills> Skills_GetAll()
        {

            return _context.Skills.ToList();
        }
    }
}
