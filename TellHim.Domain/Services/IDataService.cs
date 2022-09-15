using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TellHim.Domain.Models;

namespace TellHim.Domain.Services
{
    public interface IDataService
    {
        IEnumerable<User> GetAll();
        Task<User> Create(User user);
        Task<bool> Delete(int id);
    }
}
