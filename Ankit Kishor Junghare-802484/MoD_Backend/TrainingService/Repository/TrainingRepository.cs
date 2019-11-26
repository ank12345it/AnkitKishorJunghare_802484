using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingService.Repository;
using TrainingService.Context;
using TrainingService.Models;


namespace TrainingService.Repository
{
    public class TrainingRepository : ITrainingRepository
    {
        public readonly TrainingContext _context;
        public TrainingRepository(TrainingContext Context)
        {
            _context = Context;
        }
        
        public void  Training_Add(Training item)
        {
            _context.Training.Add(item);
            _context.SaveChanges();
        }

        public void Training_Update(Training item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }
        public List<Training> Training_GetAll()
        {
            return _context.Training.ToList();
        }
    }
}

