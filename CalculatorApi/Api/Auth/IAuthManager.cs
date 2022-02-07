using Business.Models;

namespace Api.Auth
{
    public interface IAuthManager
    {
        AuthResponse Auth(UserModel user);
    }
}