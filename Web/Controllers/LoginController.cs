using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Shared.ViewModels;
using Business;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ILoginService _loginService;


        public LoginController(IConfiguration config, ILoginService loginService)
        {
            _config = config;
            _loginService = loginService;
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(LogingViewModel login)
        {
            IActionResult response = Unauthorized();

            string key = _config["Jwt:Key"];
            string issuer = _config["Jwt:Issuer"];
            int expires = Convert.ToInt32(_config["Jwt:expires"]);

            var logged = _loginService.Login(login, key, issuer, expires);

            if (logged.Token != null)
                response = Ok(new { logged });


            return response;
        }
    }
}