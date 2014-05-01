using System;
using RibbitMVC.Models;

namespace RibbitMVC.Services
{
    public interface IUserService
    {
        User GetBy(int id);
        User GetBy(string username);
        User Create(string username, string password, UserProfile profile, DateTime? created = null);
    }
}