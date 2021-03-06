﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Charts;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class ChartController : Controller
    {

        public IActionResult MultipleAxis()
        {
            List<CategoryData> chartData = new List<CategoryData>
            {
                new CategoryData { x = "SUN", y = 35, y2 = 30 },
                new CategoryData { x = "MON", y = 40, y2 = 28 },
                new CategoryData { x = "TUE", y = 50, y2 = 29 },
                new CategoryData { x = "WED", y = 70, y2 = 30 },
                new CategoryData { x = "THU", y = 65, y2 = 33 },
                new CategoryData { x = "FRI", y = 55, y2 = 32},
                new CategoryData { x = "SAT", y = 50, y2 = 34 },                
             };
            ViewBag.dataSource = chartData;
            return View();
        }        
    }
}
