using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AssignCategoryRepository : IAssignCategoryRepository
    {
        private readonly AssignCategoryDbContext _context;

        public AssignCategoryRepository(AssignCategoryDbContext context)
        {
            _context = context;
        }

        public void Add(AssignCategory assignCategory)
        {
            _context.AssignCategory.Add(assignCategory);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var assignCategory = GetById(id);
            _context.AssignCategory.Remove(assignCategory);
            _context.SaveChanges();
        }
        public void Edit(AssignCategory assignCategory)
        {
            _context.AssignCategory.Update(assignCategory);
            _context.SaveChanges();
        }
        public AssignCategory GetById(int id)
        {
            return _context.AssignCategory.FirstOrDefault(a => a.Id == id);
        }
    }
}
