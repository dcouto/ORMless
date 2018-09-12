using Foundation.BaseClasses.MVC;
using Sitecore.Data.Items;
using System.Collections.Generic;

namespace Feature.Breadcrumb.Models
{
    public class Breadcrumb
    {
        public List<Item> Items { get; set; }
    }
}