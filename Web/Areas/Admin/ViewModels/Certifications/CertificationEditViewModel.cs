using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.Certifications
{
    public class CertificationEditViewModel : CertificationCreateViewModel
    {
        public Guid Id { get; set; }
        public string ExistingPhotoPath { get; set; }

    }
}
