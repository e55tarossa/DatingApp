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
    //15/9 xóa 2 này bỏ đổi kế thừa 
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        [AllowAnonymous]
        // IEnumerable giống list mà dễ hơn 

         public async Task<ActionResult<IEnumerable<AppUser>>>  GetUsers(){
            return  await _context.User.ToListAsync();
        }
        // Cách dưới không hiệu quả khi có nhiều request vào sever  
        // public ActionResult<IEnumerable<AppUser>> GetUsers(){
        //     return _context.User.ToList();
        // }
      

        //API/users/3 để lấy id 
        [Authorize]
        [HttpGet("{id}")]
        // IEnumerable giống list mà dễ hơn 
        public async Task<ActionResult<AppUser>>  GetUser(int id){
            return await _context.User.FindAsync(id);
        }

    }
}