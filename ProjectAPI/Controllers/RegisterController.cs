using Microsoft.AspNetCore.Mvc;
using SundaySchoolManagement.Application.Interfaces;
using SundaySchoolManagement.WebApi.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SundaySchoolManagement.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private IAuthorizeService _authorizeService;

        public RegisterController(IAuthorizeService authorizeService)
        {
            _authorizeService = authorizeService;

        }

        [HttpPost]
        public IActionResult Register(RegisterRequest model)
        {
            var user = _authorizeService.Register(model.username, model.email, model.password);

            if (user == null)
                return BadRequest("Username cold not be null");

            return Ok(user);
        }
    }
}
