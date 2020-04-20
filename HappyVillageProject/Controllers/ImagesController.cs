using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyVillageProject.Data;
using HappyVillageProject.Models;
using HappyVillageProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HappyVillageProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ImagesService _imagesService;
        
        public ImagesController(ImagesService imagesService)
        {
            _imagesService = imagesService ?? throw new ArgumentNullException(nameof(imagesService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Images>>> Get()
        {
            return await _imagesService.GetImages();
        }

       /* [HttpGet]
        public List<Images> GetImages()
        {
            var cats = new List<Images>()
        {
           new Images{Id=1,Title="Tommy" }
        };
            return  cats;
        }*/


    }
}