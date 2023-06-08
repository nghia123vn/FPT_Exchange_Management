using FPT_Exchange_Data.DTO.Internal;
using FPT_Exchange_Data.DTO.Request.Post;
using FPT_Exchange_Data.DTO.View;

namespace FPT_Exchange_Service.Implementations
{
    public interface IAuthService
    {
        Task<AuthModel?> GetUserById(Guid id);
        Task<AuthViewModel> AuthenticatedUser(AuthRequest auth);
    }
}
