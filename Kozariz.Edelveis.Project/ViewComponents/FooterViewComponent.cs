﻿using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
namespace Kozariz.Edelveis.Web.ViewComponents
   
{
    public class FooterViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Factory.StartNew(() => { return View(); });
        }
    }
}
