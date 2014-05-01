using RibbitMVC.Models;

namespace RibbitMVC.Services
{
    public interface ISecurityService
    {
        bool Authenticate(string username, string password);
        User CreateUser(string username, string password, bool login = true);
        bool DoesUserExists(string username);
        bool IsAuthenticated { get; }
        void Login(User user);
        void Login(string username);
        void Logout();
        int UserId { get; set; }
    }
}
 