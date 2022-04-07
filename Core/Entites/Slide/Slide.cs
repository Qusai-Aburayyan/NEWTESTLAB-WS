using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Slide
{
    public class Slide : EntityBase
    {
        public string SlideURL { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
