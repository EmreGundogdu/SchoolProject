using API.DTOs;
using AutoMapper;
using Core.Models;
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sinif = await _sinifService.GetByIdAsync(id);
            return Ok(_mapper.Map<SinifDto>(sinif));
        }
        [HttpGet("{id}/ogrenciler")]
        public async Task<IActionResult> GetWithStudentsByIdAsync(int id)
        {
            var sinif = await _sinifService.GetWithStudentsByIdAsync(id);
            return Ok(_mapper.Map<SinifWithOgrenciDto>(sinif));
        }
        [HttpPost]
        public async Task<IActionResult> Save(SinifDto sinifDto)
        {
            var newSinif = await _sinifService.AddAsync(_mapper.Map<Sinif>(sinifDto));
            return Created(string.Empty,_mapper.Map<SinifDto>(newSinif));
        }
        [HttpPut]
        public IActionResult Update(SinifDto sinifDto)
        {
            var sinif = _sinifService.Update(_mapper.Map<Sinif>(sinifDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var sinif = _sinifService.GetByIdAsync(id).Result;
            _sinifService.Remove(sinif);
            return NoContent();
        }
        
    }
}
