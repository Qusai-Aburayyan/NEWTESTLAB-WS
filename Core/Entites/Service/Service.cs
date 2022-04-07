using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Service
{
    public class Service : EntityBase
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ActionName { get; set; }
        public DateTime AddedDate { get; set; }
    }
}