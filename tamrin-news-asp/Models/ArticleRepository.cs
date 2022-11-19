using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ArticleDbContext _context;

        public ArticleRepository(ArticleDbContext context)
        {
            _context = context;
        }

        public void Add(Article article)
        {
            _context.Article.Add(article);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var article = GetById(id);
            _context.Article.Remove(article);
            _context.SaveChanges();
        }
        public void Edit(Article article)
        {
            _context.Article.Update(article);
            _context.SaveChanges();
        }
        public Article GetById(int id)
        {
            return _context.Article.FirstOrDefault(a => a.Id == id);
        }
    }
}
