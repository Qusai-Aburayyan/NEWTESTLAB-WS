using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.Services
{
    public class ServiceEditViewModel : ServiceCreateViewModel
    {
        public Guid Id { get; set; }
        public string ExistingPhotoPath { get; set; }

    }
}
