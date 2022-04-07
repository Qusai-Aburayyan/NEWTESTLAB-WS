using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Contactus
{
    public class Contactus : EntityBase
    {
        public string MessageTitle { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string MessageContent { get; set; }
    }
}
