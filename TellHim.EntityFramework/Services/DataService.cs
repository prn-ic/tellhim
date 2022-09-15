using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TellHim.Domain.Models;
using TellHim.Domain.Services;

namespace TellHim.EntityFramework.Services
{
    public class DataService: IDataService
    {
        private readonly TellHimDbContextFactory? _contextFactory;
        public DataService(TellHimDbContextFactory? contextFactory)
        {
            _contextFactory = contextFactory;
        }
        
        public async Task<User> Create(User user)
        {
            using (TellHimDbContext context= _contextFactory!.CreateDbContext())
            {
                EntityEntry<User> createdResut = await context.Set<User>().AddAsync(user);
                await context.SaveChangesAsync();

                return createdResut.Entity;
            }
        }
        public async Task<bool> Delete(int id)
        {
            using (TellHimDbContext context = _contextFactory!.CreateDbContext())
            {
                User? user = await context.Set<User>().FirstOrDefaultAsync(x => x.Id == id);
                context.Set<User>().Remove(user!);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (TellHimDbContext context = _contextFactory!.CreateDbContext())
            {
                IEnumerable<User>? result = context.Set<User>().ToList();


                return result!;
            }
        }
    }
}
