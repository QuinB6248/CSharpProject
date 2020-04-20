using HappyVillageProject.Data;
using HappyVillageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HappyVillageProject.Services
{
    public class ImagesService
    {
        private readonly StoredProcedures storedProcedures;
        public ImagesService(StoredProcedures storedProcedures)
        {
            this.storedProcedures = storedProcedures;
        }

        public async Task<ActionResult<IEnumerable<Images>>> GetImages()
        {
            return await storedProcedures.GetAll();
        }
    }
}
