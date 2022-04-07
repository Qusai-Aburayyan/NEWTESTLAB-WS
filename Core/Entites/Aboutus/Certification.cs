using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Aboutus
{
    public class Certification : EntityBase
    {
        public string CertificationName { get; set; }
        public string CertificationURL { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
