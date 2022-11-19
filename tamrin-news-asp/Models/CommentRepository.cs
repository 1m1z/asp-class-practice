using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CommentRepository : ICommentRepository
    {
        private readonly CommentDbContext _context;

        public CommentRepository(CommentDbContext context)
        {
            _context = context;
        }

        public void Add(Comment comment)
        {
            _context.Comment.Add(comment);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var comment = GetById(id);
            _context.Comment.Remove(comment);
            _context.SaveChanges();
        }
        public void Edit(Comment comment)
        {
            _context.Comment.Update(comment);
            _context.SaveChanges();
        }
        public Comment GetById(int id)
        {
            return _context.Comment.FirstOrDefault(a => a.Id == id);
        }
    }
}
