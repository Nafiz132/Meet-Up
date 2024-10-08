using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;       
        }

        [HttpGet]
        ActionResult<IEnumerable<AppUser>>GetUsers(){
            var users=_context.Users.ToList();
            return users;
        }

        [HttpGet("{id}")]

        ActionResult<AppUser>GetUser(int id){
            return _context.Users.Find(id);
        }
    }
}