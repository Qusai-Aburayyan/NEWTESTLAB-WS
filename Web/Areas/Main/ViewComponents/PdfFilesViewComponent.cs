using Core.Entites.WebSettings;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Main.ViewComponents
{
    public class PdfFilesViewComponent : ViewComponent
    {
        private readonly IUnitOfWork<PdfFile> _pdfFile;

        public PdfFilesViewComponent(IUnitOfWork<PdfFile> pdfFile)
        {
            _pdfFile = pdfFile;
        }
        public IViewComponentResult Invoke()
        {
            return View(_pdfFile.Entity.GetAll());
        }
    }
}
