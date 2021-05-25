using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MyShop.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();

    }

}
