using System;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Common.Entittes
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44358/images/noimage.png"
            : $"https://127.0.0.1:10000/devstoreaccount1/categorias/{ImageId}";
    }

}
