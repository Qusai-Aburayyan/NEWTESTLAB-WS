using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.Slieds
{
    public class SlideViewModel
    {
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string SlideURL { get; set; }
        public IFormFile File { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
