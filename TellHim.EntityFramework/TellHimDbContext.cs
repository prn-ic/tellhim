using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TellHim.Domain.Models;

namespace TellHim.EntityFramework
{
    public class TellHimDbContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public TellHimDbContext(DbContextOptions options): base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
