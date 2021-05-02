using API.DTOs;
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
    public class SinifController : ControllerBase
    {
        private readonly ISinifService _sinifService;
        private readonly IMapper _mapper;
        public SinifController(ISinifService sinifService, IMapper mapper)
        {
            _sinifService = sinifService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var siniflar = await _sinifService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<SinifDto>>(siniflar));
        }
    }
}
