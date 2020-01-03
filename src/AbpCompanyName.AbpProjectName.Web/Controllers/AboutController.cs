using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AbpCompanyName.AbpProjectName.Web.Controllers
{
    public class AboutController : AbpProjectNameControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}