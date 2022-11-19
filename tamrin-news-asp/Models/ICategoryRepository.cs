using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface ICategoryRepository
    {
        void Add(Category category);
        void Edit(Category category);
        Category GetById(int id);

        void Delete(int id);
    }
}
