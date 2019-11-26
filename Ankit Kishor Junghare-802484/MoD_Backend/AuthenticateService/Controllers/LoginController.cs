using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthenticateService.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AuthenticateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginInterface _repository;
        public LoginController(ILoginInterface repository)
        {
            _repository = repository;
        }
        // GET: api/Login
        [HttpGet]
        [Route("Validate/{email}/{pwd}")]
        
        public Token Get(string email, string pwd)

        {
            
            if (_repository.UserLogin(email, pwd) != null)
            {
                User response = _repository.UserLogin(email, pwd);
                return new Token() { message = "User", token =response.User_Name ,user_id=response.User_Id };

            }
            else if (_repository.MentorLogin(email,pwd)!=null)
            {
                Mentor response = _repository.MentorLogin(email, pwd);
                return new Token() { message = "Mentor", token = response.Mentor_Name };
            }
            else if (email == "ankit@gmail.com" && pwd == "adminA123")
            {
                return new Token() { message = "Admin", token ="Admin"  };
            }
            else
            {
                return new Token() { message = "Invalid User", token = "" };
            }
        }
        public string GetToken()
        {
            var _config = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json").Build();
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials
        (securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer: issuer,
        audience: audience,
        expires: DateTime.Now.AddMinutes(120),
        signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
            
        }
    }
   
}
