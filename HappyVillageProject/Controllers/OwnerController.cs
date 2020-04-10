using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyVillageProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HappyVillageProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public OwnersController(DataBaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Owners>>> GetOwners()
        {
            return await _context.Owners.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Owners>> PostOwners(Owners Owners)
        {
            _context.Owners.Add(Owners);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetOwners", new { id = Owners.OwnersId }, Owners);
        }
    }

}