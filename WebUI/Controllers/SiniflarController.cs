using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DTOs;
using WebUI.Filters;

namespace WebUI.Controllers
{
    public class SiniflarController : Controller
    {
        private readonly ISinifService _sinifService;
        private readonly IMapper _mapper;
        public SiniflarController(ISinifService sinifService, IMapper mapper)
        {
            _sinifService = sinifService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var siniflar = await _sinifService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<SinifDto>>(siniflar));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(SinifDto sinifDto)
        {
            await _sinifService.AddAsync(_mapper.Map<Sinif>(sinifDto));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int id)
        {
            var sinif = await _sinifService.GetByIdAsync(id);
            return View(_mapper.Map<SinifDto>(sinif));
        }
        [HttpPost]
        public IActionResult Update(SinifDto sinifDto)
        {
            _sinifService.Update(_mapper.Map<Sinif>(sinifDto));
            return RedirectToAction("Index");
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        public IActionResult Delete(int id)
        {
            var sinif = _sinifService.GetByIdAsync(id).Result;
            _sinifService.Remove(sinif);
            return RedirectToAction("Index");
        }
    }
}
