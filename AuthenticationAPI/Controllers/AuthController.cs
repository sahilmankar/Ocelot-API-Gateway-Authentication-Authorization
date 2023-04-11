using AuthenticationAPI.Models;
using AuthenticationAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAPI.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _svc;
        public AuthController(IUserService svc)
        {
            _svc = svc;

        }
                        /* user data 
                        +--------------------+----------+-------+
                        | email              | password | role  |
                        +--------------------+----------+-------+
                        | admin123@gmail.com | admin123 | Admin |
                        | user123@gmail.com  | user123  | User  |
                        +--------------------+----------+-------+
                        */

        [HttpPost("login")]  // URL - http://localhost:5235/api/auth/login
        public IActionResult Authenticate([FromBody] AuthenticateRequest request)
        {
            var user = _svc.Authenticate(request);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        // This method is not reuired 

        [HttpGet("/getall")]  // URL- http://localhost:5235/api/auth/getall
        public IEnumerable<User> GetAll()
        {
            var users = _svc.GetAll();
            return users;
        }
    }
}