using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DTOs;

namespace WebUI.Controllers
{
    public class OgretmenlerController : Controller
    {
        private readonly IOgretmenService _ogretmenService;

        private readonly IMapper _mapper;
        public OgretmenlerController(IOgretmenService ogretmenService, IMapper mapper)
        {
            _ogretmenService = ogretmenService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var ogretmenler = await _ogretmenService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<OgretmenDto>>(ogretmenler));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(OgretmenDto ogretmenDto)
        {
            await _ogretmenService.AddAsync(_mapper.Map<Ogretmen>(ogretmenDto));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int id)
        {
            var ogretmen = await _ogretmenService.GetByIdAsync(id);
            return View(_mapper.Map<OgretmenDto>(ogretmen));
        }
        [HttpPost]
        public IActionResult Update(OgretmenDto ogretmenDto)
        {
            _ogretmenService.Update(_mapper.Map<Ogretmen>(ogretmenDto));
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var ogretmen = _ogretmenService.GetByIdAsync(id).Result;
            _ogretmenService.Remove(ogretmen);
            return RedirectToAction("Index");
        }
    }
}
