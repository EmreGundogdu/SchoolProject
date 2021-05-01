﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SinifId { get; set; }
        public virtual Sinif Sinif { get; set; }
    }
}
