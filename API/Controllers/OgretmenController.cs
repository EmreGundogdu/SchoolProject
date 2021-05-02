using AutoMapper;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgretmenlerController : ControllerBase
    {
        private readonly IOgretmenService _ogretmenService;
        private readonly IMapper _mapper;
        public OgretmenlerController(IOgretmenService ogretmenService, IMapper mapper)
        {
            _ogretmenService = ogretmenService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ogretmenler = await _ogretmenService.GetAllAsync();
            return Ok(ogretmenler);
        }
    }
}
