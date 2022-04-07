using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Aboutus

{
    public class Aboutus : EntityBase
    {
        public string ImageURL { get; set; }
        public string VisionMissionText { get; set; }
        public string Para1 { get; set; }
        public string Para2 { get; set; }
        public string QPParagraph { get; set; }
    }
}
