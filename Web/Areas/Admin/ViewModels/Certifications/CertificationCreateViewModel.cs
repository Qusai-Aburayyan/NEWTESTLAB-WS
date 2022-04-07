using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.Certifications
{
    public class CertificationCreateViewModel
    {
        public string CertificationName { get; set; }
        public string CertificationURL { get; set; }
        public DateTime AddedDate { get; set; }
        public IFormFile File { get; set; }

    }
}
