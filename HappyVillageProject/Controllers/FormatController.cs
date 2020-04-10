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
    public class FormatsController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public FormatsController(DataBaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Formats>>> GetFormats()
        {
            return await _context.Formats.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Formats>> PostFormats(Formats Formats)
        {
            _context.Formats.Add(Formats);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetFormats", new { id = Formats.FormatsId }, Formats);
        }

    }
   
    



}