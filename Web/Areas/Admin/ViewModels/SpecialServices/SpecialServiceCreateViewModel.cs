using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels.SpecialServices
{
    public class SpecialServiceCreateViewModel
    {
        [Required]
        [Display(Name = "Service Title")]
        [MaxLength(30, ErrorMessage = "Title canno't exceed 30 characters")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Service Description")]
        public string Content { get; set; }
        [Required]
        [Display(Name = "Action Name")]
        public string ActionName { get; set; }
        public DateTime AddedDate { get; set; }
        [Required]
        [Display(Name = "Service Image")]
        public IFormFile File { get; set; }

    }
}
