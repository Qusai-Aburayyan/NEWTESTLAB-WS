using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.WebSettings
{
    public class PdfFile : EntityBase
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
