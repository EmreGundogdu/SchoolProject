using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.DTOs
{
    public class SinifWithOgrenciDto : SinifDto
    {
        public IEnumerable<OgrenciDto> Ogrenciler { get; set; }
    }
}
