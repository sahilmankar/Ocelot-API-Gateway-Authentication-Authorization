using AuthenticationAPI.Models;
using AuthenticationAPI.Repositories.Interfaces;
using AuthenticationAPI.Services.Interfaces;

namespace AuthenticationAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userrepo;
        public UserService(IUserRepository userrepo)
        {
            _userrepo = userrepo;
        }
        public AuthenticateResponse Authenticate(AuthenticateRequest request)
        {
            return _userrepo.Authenticate(request);
        }
        public List<User> GetAll()
        {
            return _userrepo.GetAll();
        }
    }
}