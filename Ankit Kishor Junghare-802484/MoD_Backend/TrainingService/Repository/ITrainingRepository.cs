using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingService.Models;

namespace TrainingService.Repository
{
   public interface ITrainingRepository
    {
        void Training_Add(Models.Training item);
        void Training_Update(Models.Training item);
        List<Models.Training> Training_GetAll();

    }
}
