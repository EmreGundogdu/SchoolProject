using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class OgrenciWithSinifDto:OgrenciDto
    {
        public SinifDto Sinif { get; set; }
    }
}
