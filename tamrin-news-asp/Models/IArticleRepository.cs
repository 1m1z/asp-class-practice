using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface IArticleRepository
    {
        void Add(Article article);
        void Edit(Article article);
        Article GetById(int id);

        void Delete(int id);
    }
}
