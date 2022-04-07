using Core.Entites.Contactus;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactusController : Controller
    {
        private readonly IUnitOfWork<Contactus> _contactus;

        public ContactusController(IUnitOfWork<Contactus> contactus)
        {
            _contactus = contactus;
        }

        public IActionResult Index()
        {
            return View(_contactus.Entity.GetAll());
        }
        public IActionResult Read(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contact = _contactus.Entity.GetById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

    }
}
