using Foundation.BaseClasses.MVC;
using Sitecore.Data.Items;

namespace Feature.GenericCard.Models
{
    public class GenericCard : BaseModel
    {
        public string BackgroundColor { get; set; }

        public GenericCard(Item item) : base(item)
        {
        }
    }
}