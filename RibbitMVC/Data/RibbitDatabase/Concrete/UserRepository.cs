using RibbitMVC.Data.RibbitDatabase.Abstract;
using RibbitMVC.Models;

namespace RibbitMVC.Data.RibbitDatabase.Concrete
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(EFDbContext context, bool sharedContext) : base(context, sharedContext) {}

        public User GetBy(int id)
        {
            return Find(u => u.Id == id);
        }

        public User GetBy(string username)
        {
            return Find(u => u.Username == username);
        }
    }
}