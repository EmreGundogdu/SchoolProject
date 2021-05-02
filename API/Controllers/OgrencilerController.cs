using API.DTOs;
using API.Filters;
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
    public class OgrencilerController : ControllerBase
    {
        private readonly IOgrenciService _ogrenciService;
        private readonly IMapper _mapper;
        public OgrencilerController(IOgrenciService ogrenciService, IMapper mapper)
        {
            _ogrenciService = ogrenciService;
            _mapper = mapper;
        }        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ogrenciler = await _ogrenciService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<OgrenciDto>>(ogrenciler));
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ogrenci = await _ogrenciService.GetByIdAsync(id);
            return Ok(_mapper.Map<OgrenciDto>(ogrenci));
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/sinif")]
        public async Task<IActionResult> GetWitchSinifById(int id)
        {
            var ogrenci = await _ogrenciService.GetWithSinifByIdAsync(id);
            return Ok(_mapper.Map<OgrenciWithSinifDto>(ogrenci));
        }        
        [HttpPost]
        public async Task<IActionResult> Save(OgrenciDto ogrenciDto)
        {
            var newOgrenci = await _ogrenciService.AddAsync(_mapper.Map<Ogrenci>(ogrenciDto));
            return Created(string.Empty, _mapper.Map<OgrenciDto>(newOgrenci));
        }
        [HttpPut]
        public IActionResult Update(OgrenciDto ogrenciDto)
        {
            var ogrenci = _ogrenciService.Update(_mapper.Map<Ogrenci>(ogrenciDto));
            return NoContent();
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var ogrenci = _ogrenciService.GetByIdAsync(id).Result;
            _ogrenciService.Remove(ogrenci);
            return NoContent();
        }

    }
}
