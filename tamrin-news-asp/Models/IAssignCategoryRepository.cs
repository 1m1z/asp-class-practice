using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface IAssignCategoryRepository
    {
        void Add(AssignCategory assignCategory);
        void Edit(AssignCategory assignCategory);
        AssignCategory GetById(int id);

        void Delete(int id);
    }
}
