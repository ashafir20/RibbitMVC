using System;
using RibbitMVC.Data.RibbitDatabase.Concrete;

namespace RibbitMVC.Data.RibbitDatabase.Abstract
{
    public interface IContext : IDisposable
    {
        IUserRepository Users { get; }
        IRibbitRepository Ribbits { get; }
        int SaveChanges();
    }
}