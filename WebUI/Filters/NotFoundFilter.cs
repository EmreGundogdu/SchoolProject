using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DTOs;

namespace WebUI.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {
        private readonly ISinifService _sinifService;

        public NotFoundFilter(ISinifService sinifService)
        {
            _sinifService = sinifService;
        }
        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var ogrenci = await _sinifService.GetByIdAsync(id);
            if (ogrenci!=null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Errors.Add($"Id'si {id} olan sinif veritabanında bulunamadı.");
                context.Result = new RedirectToActionResult("Error","Home",errorDto);
            }
        }
    }
}
