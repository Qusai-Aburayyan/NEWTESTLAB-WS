using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.WebSettings
{
    public class WebSettingsViewModel
    {
        public Guid Id { get; set; }
        public string LogoURL { get; set; }
        public IFormFile File1 { get; set; }
        public string Adress { get; set; }
        public string EmailAdress { get; set; }
        public string FbAdress { get; set; }
        public string InstaAdress { get; set; }
        public string LinkedinAdress { get; set; }
        public string WhatsApp { get; set; }
        public string Phone { get; set; }
        public string FotterLogoURL { get; set; }
        public IFormFile File2 { get; set; }
        public string FotterText { get; set; }

    }
}
