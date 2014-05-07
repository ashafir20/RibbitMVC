using RibbitMvc.Models;
using RibbitMvc.ViewModel;

namespace RibbitMvc.Services
{
    public interface ISecurityService
    {
        bool Authenticate(string username, string password);
        User CreateUser(SignupViewModel signupModel, bool login = true);
        bool DoesUserExist(string username);
        User GetCurrentUser();
        bool IsAuthenticated { get; }
        void Login(User user);
        void Login(string username);
        void Logout();
        int UserId { get; set; }
    }
}