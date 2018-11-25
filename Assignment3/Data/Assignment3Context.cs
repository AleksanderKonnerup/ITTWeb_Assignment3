using Assignment3.Models;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Assignment3.Data
{
    public class Assignment3Context : DbContext
    {
        public Assignment3Context (DbContextOptions<Assignment3Context> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<ComponentType> ComponentType { get; set; }

        public DbSet<Component> Component { get; set; }
    }
}
