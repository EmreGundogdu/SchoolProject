using Core.Models;
using DataAccess.Configurations;
using DataAccess.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OgrenciConfiguration());
            modelBuilder.ApplyConfiguration(new SinifConfiguration());
            modelBuilder.ApplyConfiguration(new OgretmenConfiguration());

            modelBuilder.ApplyConfiguration(new OgrenciSeed());
            modelBuilder.ApplyConfiguration(new SinifSeed());
            modelBuilder.ApplyConfiguration(new OgretmenSeed());
        }
    }

}
