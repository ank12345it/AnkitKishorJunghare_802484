using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnologyService.Models;

namespace TechnologyService.Repository
{
   public interface ISkillsRepository
    {
        void Skills_Add(Skills item);
        List<Skills> Skills_GetAll();
        void Skills_Update(Skills item);



        //void User_Update(User item);


    }
}
