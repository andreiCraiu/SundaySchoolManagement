using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SundaySchoolManagement.Application.Interfaces;
using SundaySchoolManagement.Domain.DatabaseEntities;
using SundaySchoolManagement.WebApi.View;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LoginController : ControllerBase
    {
        private IAuthorizeService _authorizeService;

        public LoginController(IAuthorizeService authorizeService)
        {
            _authorizeService = authorizeService;

        }

        [HttpPost]
        public IActionResult Authorize(LoginRequest model)
        {
            var user = _authorizeService.Authenticate(model.Email, model.Password);

            if (user == null)
                return BadRequest("Username or password is incorrect");

            return Ok(user);
          }
    }
}
