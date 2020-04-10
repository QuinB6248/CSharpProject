using HappyVillageProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyVillageProject
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Images> Images { get; set; }
        public DbSet<Formats> Formats { get; set; }
        public DbSet<Owners> Owners { get; set; }
    }
}
