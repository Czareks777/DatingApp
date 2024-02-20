using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUsers>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id}")] // /api/users/2
        public async Task<ActionResult<AppUsers>> GetUserAsync(int id)
        {
            var user = _context.Users.FindAsync(id);
            return await user;
        }

    }
}