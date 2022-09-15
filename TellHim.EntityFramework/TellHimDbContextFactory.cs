using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellHim.EntityFramework
{
    public class TellHimDbContextFactory: IDesignTimeDbContextFactory<TellHimDbContext>
    {
        public TellHimDbContext CreateDbContext(string[] args = null!)
        {
            var options = new DbContextOptionsBuilder<TellHimDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=TellHim; Trusted_Connection=True;");
            
            return new TellHimDbContext(options.Options);
        }
    }
}
