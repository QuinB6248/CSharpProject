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
    public class DataBaseController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public DataBaseController(DataBaseContext context)
        {
            _context = context;
        }
       /*[HttpGet]
        public async Task<ActionResult<IEnumerable<Images>>> GetImages()
        {
            return await _context.Images.ToListAsync();
        }*/
        
        
        
        
        
        //[HttpGet]
        //public IEnumerable<Images> GetImages()
        //{
        //   return  _context.Images.ToList();
        //}

        /*[HttpGet]
        public IEnumerable<Images> AddImages(string name, string img, string subject, string description, Format format, Owner owner)
        {
            var image = new Images
            {
                Name = name,
                Img = img,
                Subject = subject,
                Description = description,
                Format = format,
                Owner = owner

            };
            return _context.Images.Add(image);
        }*/

       
        
        
        
        /*[HttpPost]
        public async Task<ActionResult<IEnumerable<Images>>> PostImages(Images Images)
        {
            _context.Images.Add(Images);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetImages", new { id = Images.Id }, Images);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Format>>> PostFormat(Format Format)
        {
            _context.Format.Add(Format);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetFormat", new { id = Format.Id }, Format);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Images>>> PostOwner(Owner Owner)
        {
            _context.Owner.Add(Owner);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetOwner", new { id = Owner.Id }, Owner);
        }
        */

    }
}