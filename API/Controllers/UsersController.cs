using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // este controlador será para traer toda la informacion de los usuario 
    // y de un usuario en particular
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            this._context = context;
        }


        [HttpGet] // utilizaremos el verbo HttpGet
        [AllowAnonymous] // Permitiremos que cualquiera pueda hacer esta peticion sin importar si esta autenticado
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // * Note: api/users/3
        [Authorize] // solo aquellos que tengan el Token podan acceder a la informacion de un usuario en particular 
        [HttpGet("{id}")] // y buscaremos un usuario en particular especificando su id
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }



    }
}