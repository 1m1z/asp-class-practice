using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AssignCategoryDbContext : DbContext
    {
        public AssignCategoryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AssignCategory> AssignCategory { get; set; }
    }
}
