using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface ICommentRepository
    {
        void Add(Comment comment);
        void Edit(Comment comment);
        Comment GetById(int id);

        void Delete(int id);
    }
}
