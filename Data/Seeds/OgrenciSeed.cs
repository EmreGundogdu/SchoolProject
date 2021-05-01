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
    public class OgrenciSeed:IEntityTypeConfiguration<Ogrenci>
    {
        private readonly int[] _ids;
        public OgrenciSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.HasData(new Ogrenci { Id = 1, Name = "Emre", SinifId = _ids[0] }, new Ogrenci { Id = 2, Name = "Fatih", SinifId = _ids[1] });
        }
    }
}
