using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Web.Models
{
    public class AddProductImageViewModel
    {
        public int ProductId { get; set; }

        [Display(Name = "Image")]
        [Required]
        public IFormFile ImageFile { get; set; }
    }

}
