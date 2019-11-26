using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMentor.Models;

namespace UserMentor.Repository
{
    public interface IMentorRepository
    {
        void Mentor_Add(Mentor item);
        List<Mentor> Mentor_GetAll();
        void Mentor_Update(Mentor item);
        void Mentor_Delete(long id);

        void Mentor_Block(long id);


    }
}
