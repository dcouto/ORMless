using Foundation.BaseClasses.Services;
using Foundation.Extensions;
using Foundation.Site.Factories;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

namespace Feature.GlobalSearch.Services
{
    public class GlobalSearchService : BaseService, IGlobalSearchService
    {
        public Models.GlobalSearch GetGlobalSearch(RenderingContext renderingContext, Item contextItem, string q)
        {
            var model = new Models.GlobalSearch(GetDatasource(renderingContext, contextItem, Global_Search_Constants.TemplateId));

            model.Results = GetResults(q, contextItem.Database.Name);

            model.SearchBoxPlaceholderText = GetSearchBoxPlaceholderText(q, model.SitecoreItem);

            return model;
        }

        private string GetSearchBoxPlaceholderText(string q, Item sitecoreItem)
        {
            if (q.IsNotNullAndNotWhiteSpace())
            {
                return q;
            }
            else
            {
                using (var fr = new FieldRenderer())
                {
                    fr.Item = sitecoreItem;
                    fr.FieldName = Global_Search_Constants.Keywords_Textbox_Watermark_FieldName;
                    fr.DisableWebEditing = true;

                    return fr.Render();
                }
            }
        }

        private List<Item> GetResults(string q, string databaseName)
        {
            if (q.IsNotNullAndNotWhiteSpace())
            {
                using (var searcher = ContentSearchManager.GetIndex(string.Format("sitecore_{0}_index", databaseName)).CreateSearchContext())
                {
                    var site = SiteFactory.GetSite();

                    return searcher
                        .GetQueryable<SearchResultItem>()
                        .Where(i =>
                            i.Paths.Contains(site.SitecoreItem.ID)
                            &&
                            i.Content == q)
                        .ToList()
                        .Select(i => i.GetItem())
                        .ToList();
                }
            }
            else
            {
                return new List<Item>();
            }
        }
    }
}