using System.Collections.Generic;
using RibbitMVC.Data.RibbitDatabase.Abstract;
using RibbitMVC.Models;

namespace RibbitMVC.Data.RibbitDatabase.Concrete
{
    public interface IRibbitRepository : IRepository<Ribbit>
    {
        Ribbit GetBy(int id);
        IEnumerable<Ribbit> GetFor(User user);
        void AddFor(Ribbit ribbit, User user);
    }
}