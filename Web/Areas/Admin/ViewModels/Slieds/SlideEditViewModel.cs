using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.Slieds
{
    public class SlideEditViewModel : SlideViewModel
    {
        public Guid Id { get; set; }
        public string ExstingSlideURL { get; set; }
    }
}
