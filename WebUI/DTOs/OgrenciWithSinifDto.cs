using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.DTOs
{
    public class OgrenciWithSinifDto:OgrenciDto
    {
        public SinifDto Sinif { get; set; }
    }
}
