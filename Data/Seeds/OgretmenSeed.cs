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
    public class OgretmenSeed : IEntityTypeConfiguration<Ogretmen>
    {
        public void Configure(EntityTypeBuilder<Ogretmen> builder)
        {
            builder.HasData(new Ogretmen { Id = 1, Name = "Öğretmen 1", Surname = "Gündoğdu" }, new Ogretmen { Id = 2, Name = "Öğretmen 2", Surname = "Öztürk" });
        }
    }
}
