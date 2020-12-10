using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vroom.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> Items)
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();

            SelectListItem selectListItem = new SelectListItem { Text = "---Select---", Value = "0" };

            selectListItems.Add(selectListItem);
            foreach (var item in Items)
            {
                selectListItem = new SelectListItem
                {
                    Text = item.GetPropertyValue("Name"),
                    Value = item.GetPropertyValue("Id")
                    //Text = item.GetType().GetProperty("Name").GetValue(item, null).ToString(),
                    //Value = item.GetType().GetProperty("Id").GetValue(item, null).ToString()
                };
                selectListItems.Add(selectListItem);
            }
            return selectListItems;
        }
    }
}
