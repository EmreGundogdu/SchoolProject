using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class OgretmenDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} Alanı boş bırakılamaz")]
        public string Name { get; set; }
    }
}
