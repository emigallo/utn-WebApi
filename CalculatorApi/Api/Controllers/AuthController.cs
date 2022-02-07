using System;
using System.Threading.Tasks;
using Api.Auth;
using Api.Context;
using Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private BaseCalculatorDbContext _context;

        public AuthController(BaseCalculatorDbContext context)
        {
            this._context = context;
        }

        [AllowAnonymous]
        [HttpGet("Token")]
        public async Task<IActionResult> Authenticate(string userName, string password)
        {
            try
            {
                UserModel user = await this._context.Users.FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password);
                AuthResponse response = new AuthManager().Auth(user);
                return Ok(response);
            }
            catch (Exception ex)
            {
                if (ex.Message == "USER_NON_EXIST")
                {
                    return Ok("Usuario o contraseña inexistente.");
                }

                if (ex.Message == "INVALID_TOKEN_REQUEST")
                {
                    return Unauthorized();
                }

                return BadRequest("Ocurrió un error inesperado");
            }
        }
    }
}