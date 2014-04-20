using RibbitMVC.Models;

namespace RibbitMVC.Data.RibbitDatabase.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        User GetBy(int id);
        User GetBy(string username);
    }
}