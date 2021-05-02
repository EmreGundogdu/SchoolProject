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
    public class SinifSeed : IEntityTypeConfiguration<Sinif>
    {
        
        public void Configure(EntityTypeBuilder<Sinif> builder)
        {
            builder.HasData(new Sinif { Id = 1, Name = "İlkokul"}, new Sinif { Id = 2, Name = "Ortaokul"});
        }
    }
}
