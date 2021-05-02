
using AutoMapper;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DTOs;

namespace WebUI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Sinif, SinifDto>();
            CreateMap<SinifDto, Sinif>();

            CreateMap<Sinif, SinifWithOgrenciDto>();
            CreateMap<SinifWithOgrenciDto, Sinif>();

            CreateMap<Ogrenci, OgrenciDto>();
            CreateMap<OgrenciDto, Ogrenci>();

            CreateMap<Ogrenci, OgrenciWithSinifDto>();
            CreateMap<OgrenciWithSinifDto, Ogrenci>();
        }
    }
}
