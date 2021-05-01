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
        private readonly int[] _ids;
        public SinifSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Sinif> builder)
        {
            builder.HasData(new Sinif { Id = _ids[0], Name = "İlkokul" }, new Sinif { Id = _ids[1], Name = "Ortaokul" });
        }
    }
}
