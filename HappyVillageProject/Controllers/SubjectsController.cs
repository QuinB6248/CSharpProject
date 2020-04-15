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
    public class SubjectsController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public SubjectsController(DataBaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subjects>>> GetSubjects()
        {
            return await _context.Subjects.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Subjects>> PostSubjects(Subjects Subjects)
        {
            _context.Subjects.Add(Subjects);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetSubjects", new { id = Subjects.SubjectsId }, Subjects);
        }

    }
   
    



}