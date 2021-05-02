using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class OgrenciSeed : IEntityTypeConfiguration<Ogrenci>
    {

        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.HasData(new Ogrenci { Id = 1, Name = "Emre" }, new Ogrenci { Id = 2, Name = "Fatih" });
        }
    }
}
