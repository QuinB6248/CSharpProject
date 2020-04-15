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
    public class ImagesController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public ImagesController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Images>>> GetImages()
        {
            return await _context.Images.Include(i => i.User).ToListAsync();
        }
     

        [HttpPost]
        public async Task<ActionResult<Images>> PostImages(Images Images)
        {
            _context.Images.Add(Images);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetImages", new { id = Images.ImagesId }, Images);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Images>> GetTodoItem(int id)
        {
            var image = await _context.Images.FindAsync(id);
            
            if (image == null)
            {
                return NotFound();
            }

            return image;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Images>> PutImages(int id, Images image )
        {
            if (id != image.ImagesId)
            {
                return BadRequest();
            }

            _context.Entry(image).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!ImagesExists(id))
                {
                    return NotFound();
                }
                else { throw; }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Images>> DeleteImages(int id)
        {
            var image = await _context.Images.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }

            _context.Images.Remove(image);
            await _context.SaveChangesAsync();

            return image;
        }
        private bool ImagesExists(int id)
        {
            return _context.Images.Any(e => e.ImagesId == id);
        }
    }
   
}