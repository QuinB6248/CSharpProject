using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyVillageProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HappyVillageProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // private UserManager<AppUser> UserMgr { get; }
       // private SignInManager<AppUser> SignInMgr { get; }
        private readonly DataBaseContext _context;
        //public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, DataBaseContext context)
        public AccountController(DataBaseContext context)
        {
           // UserMgr = userManager;
           // SignInMgr = signInManager;
            _context = context;
        }

      /*  [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUser()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<AppUser>> PostAppUser(AppUser AppUser)
        {
            _context.Users.Add(AppUser);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetAppUser", new { id = AppUser.Id }, AppUser);
        }

       */

    }
}



/* public async Task<IActionResult> Register()
        {
            try
            {
                Console.WriteLine("User Already Registered");
                AppUser user = await UserMgr.FindByNameAsync("TestUser");
                if (user == null)
                {
                    user = new AppUser();
                    user.UserName = "TestUser";
                    user.Email = "TestUser@test.com";
                    user.FirstName = "Jane";
                    user.LastName = "Doe";

                    IdentityResult result = await UserMgr.CreateAsync(user, "Test123!");

                    Console.WriteLine("User Was Created");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return {};
        }*/
