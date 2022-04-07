using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.WebSettings
{
    public class WebSettings : EntityBase
    {
        public string LogoURL { get; set; }
        public string Adress { get; set; }
        public string EmailAdress { get; set; }
        public string FbAdress { get; set; }
        public string InstaAdress { get; set; }
        public string LinkedinAdress { get; set; }
        public string WhatsApp { get; set; }
        public string Phone { get; set; }
        public string FotterLogoURL { get; set; }
        public string FotterText { get; set; }

    }
}
