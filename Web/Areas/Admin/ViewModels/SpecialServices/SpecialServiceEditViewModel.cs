using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.SpecialServices
{
    public class SpecialServiceEditViewModel : SpecialServiceCreateViewModel
    {
        public Guid Id { get; set; }
        public string ExistingPhotoPath { get; set; }

    }
}
