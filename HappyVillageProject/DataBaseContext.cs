using HappyVillageProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity.EntityFramework;

namespace HappyVillageProject
{
    public class DataBaseContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Images> Images { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
       // public DbSet<Owners> Owners { get; set; }
    }
}





/*public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {

    }

    public DbSet<Images> Images { get; set; }
    public DbSet<Subjects> Subjects { get; set; }
    public DbSet<Owners> Owners { get; set; }
}*/