using MyShop.Common.Entittes;
using MyShop.Web.Models;
using System;

namespace MyShop.Web.Helpers
{
    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);
    }

}
