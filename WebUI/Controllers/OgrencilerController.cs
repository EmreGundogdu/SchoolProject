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
    public class OgrencilerController : Controller
    {
        private readonly IOgrenciService _ogrenciService;
        private readonly IMapper _mapper;
        public OgrencilerController(IOgrenciService ogrenciService, IMapper mapper)
        {
            _ogrenciService = ogrenciService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var ogrenciler = await _ogrenciService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<OgrenciDto>>(ogrenciler));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(OgrenciDto ogrenciDto)
        {
            await _ogrenciService.AddAsync(_mapper.Map<Ogrenci>(ogrenciDto));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int id)
        {
            var ogrenci = await _ogrenciService.GetByIdAsync(id);
            return View(_mapper.Map<OgrenciDto>(ogrenci));
        }
        [HttpPost]
        public IActionResult Update(OgrenciDto ogrenciDto)
        {
            _ogrenciService.Update(_mapper.Map<Ogrenci>(ogrenciDto));
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var ogrenci = _ogrenciService.GetByIdAsync(id).Result;
            _ogrenciService.Remove(ogrenci);
            return RedirectToAction("Index");
        }
    }
}
