using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.SpecialService
{
    public class SpecialService : EntityBase
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ActionName { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
