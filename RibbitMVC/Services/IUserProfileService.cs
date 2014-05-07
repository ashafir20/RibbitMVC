using RibbitMvc.Models;
using RibbitMvc.ViewModel;

namespace RibbitMvc.Services
{
    public interface IUserProfileService
    {
        UserProfile GetBy(int id);
        void Update(EditProfileViewModel model);
    }
}