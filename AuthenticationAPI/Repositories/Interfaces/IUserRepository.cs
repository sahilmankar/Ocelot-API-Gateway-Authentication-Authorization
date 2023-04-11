using AuthenticationAPI.Models;

namespace AuthenticationAPI.Repositories.Interfaces
{
    public interface IUserRepository
    {
        AuthenticateResponse Authenticate(AuthenticateRequest request);
        List<User> GetAll();
    }
}