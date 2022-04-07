﻿using Core.Entites.WebSettings;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Main.ViewModels;

namespace Web.Areas.Main.ViewComponents
{
    public class SharedViewComponent : ViewComponent
    {
        private readonly IUnitOfWork<WebSettings> _webSettings;

        public SharedViewComponent(
            IUnitOfWork<WebSettings> webSettings)
        {
            _webSettings = webSettings;
        }

        public IViewComponentResult Invoke(Guid? id)
        {
            var sharedViewModel = new SharedViewModel
            {
                WebSettings = _webSettings.Entity.GetAll().First()
            };
            return View(sharedViewModel);
        }
    }
}
