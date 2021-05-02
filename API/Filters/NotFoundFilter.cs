using API.DTOs;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {
        private readonly IOgrenciService _ogrenciService;

        public NotFoundFilter(IOgrenciService ogrenciService)
        {
            _ogrenciService = ogrenciService;
        }
        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var ogrenci = await _ogrenciService.GetByIdAsync(id);
            if (ogrenci!=null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"Id'si {id} olan ogrenci veritabanında bulunamadı.");
                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}
