using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class UsersController:ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context=context;
        }
    
    [HttpGet]
    public ActionResult<IEnumerable<AppUsers>> GetUsers()
    {
        var users = _context.Users.ToList();
        return users;
    }
    
    [HttpGet("{id}")] // /api/users/2
    public ActionResult<AppUsers>GetUser(int id)
    {
        var user = _context.Users.Find(id);
        return user;
    }
    
    }
}