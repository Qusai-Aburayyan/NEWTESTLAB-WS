using Core.Entites.Aboutus;
using Core.Entites.Contactus;
using Core.Entites.Service;
using Core.Entites.Slide;
using Core.Entites.SpecialService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Main.ViewModels
{
    public class HomeViewModel
    {
        public List<Slide> Slides { get; set; }
        public Aboutus Aboutus { get; set; }
        public List<Service> Services { get; set; }
        public List<SpecialService> SpecialServices { get; set; }
    }
}
