using Foundation.BaseClasses.Services;
using Foundation.Events;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Linq;

namespace Feature.Events.Services
{
    public class EventsService : BaseService, IEventsService
    {
        public Models.EventsListing GetEventsLsting(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.EventsListing(GetDatasource(renderingContext, contextItem, Events_Listing_Constants.TemplateId));

            using(var searcher = ContentSearchManager.GetIndex(string.Format("sitecore_{0}_index", contextItem.Database.Name)).CreateSearchContext())
            {
                model.UpcomingEvents = searcher
                        .GetQueryable<SearchResultItem>()
                        .Where(i =>
                            i.Paths.Contains(contextItem.ID))
                        .ToList()
                        .Select(i => i.GetItem())
                        .ToList();
            }

            return model;
        }
    }
}