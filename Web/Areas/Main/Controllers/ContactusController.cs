using Core.Entites.Contactus;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Main.Controllers
{
    [AllowAnonymous]
    [Area("Main")]

    public class ContactusController : Controller
    {
        private readonly IUnitOfWork<Contactus> _contactus;

        public ContactusController(IUnitOfWork<Contactus> contactus)
        {
            _contactus = contactus;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveContact(Contactus model)
        {
            if (ModelState.IsValid)
            {
                Contactus contactus = new Contactus
                {
                    MessageTitle = model.MessageTitle,
                    Email = model.Email,
                    MessageContent = model.MessageContent,
                    Name = model.Name,
                    Phone = model.Phone
                };

                _contactus.Entity.Insert(contactus);
                _contactus.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
