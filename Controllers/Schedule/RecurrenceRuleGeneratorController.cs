﻿using Microsoft.AspNetCore.Mvc;


namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {

        public IActionResult RecurrenceRuleGenerator()
        {
            return View();
        }

    }
}
