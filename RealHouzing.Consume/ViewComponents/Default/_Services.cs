﻿using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _Services:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}