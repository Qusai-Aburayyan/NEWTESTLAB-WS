using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.Aboutus
{
    public class AboutusViewModel
    {
        public Guid Id { get; set; }
        public string VisionMissionText { get; set; }
        public string Para1 { get; set; }
        public string Para2 { get; set; }
        public string QPParagraph { get; set; }
        public string ImageURL { get; set; }
        public IFormFile File { get; set; }

    }
}
