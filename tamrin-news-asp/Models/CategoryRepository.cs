using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDbContext _context;

        public CategoryRepository(CategoryDbContext context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            _context.Category.Remove(category);
            _context.SaveChanges();
        }
        public void Edit(Category category)
        {
            _context.Category.Update(category);
            _context.SaveChanges();
        }
        public Category GetById(int id)
        {
            return _context.Category.FirstOrDefault(a => a.Id == id);
        }
    }
}
