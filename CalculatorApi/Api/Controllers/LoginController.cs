using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Context;
using Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        private BaseCalculatorDbContext _context;

        public LoginController(BaseCalculatorDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            List<LoginModel> list = this._context.Logins.ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("today")]
        public async Task<ActionResult> GetToday()
        {
            IQueryable<LoginModel> list = this._context.Logins.Where(x => x.Date.Date == DateTime.Today.Date); 
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult> Insert(LoginModel model)
        {
            try
            {
                await this._context.AddAsync(model);
                if (await this._context.SaveChangesAsync() > 0)
                {
                    return Ok("El registro se guardó exitosamente");
                }

                return Ok("No se pudo guardar el registro");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}