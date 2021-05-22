using Microsoft.AspNetCore.Http;
using MyShop.Common.Entittes;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Web.Models
{
    public class CategoryViewModel : Category
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }

}
