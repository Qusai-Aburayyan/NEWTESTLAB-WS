using Core.Entites.Aboutus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.AboutusPageViewModel
{
    public class AboutusPageViewModel
    {
        //public Aboutus Aboutus { get; set; }
        public List<Certification> Certifications { get; set; }
        public List<QualityPolicy> QualityPolicies { get; set; }

    }
}
