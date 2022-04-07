using Core.Entites.WebSettings;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Main.ViewComponents
{
    public class SocialMediaAddressesViewComponent : ViewComponent
    {
        private readonly IUnitOfWork<SocialMediaAddresses> _socialMediaAddresses;

        public SocialMediaAddressesViewComponent(IUnitOfWork<SocialMediaAddresses> socialMediaAddresses)
        {
            _socialMediaAddresses = socialMediaAddresses;
        }
        public IViewComponentResult Invoke()
        {
            return View(_socialMediaAddresses.Entity.GetAll().First());
        }
    }
}
