using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace Foundation.Events.Services
{
    public class EventsService : BaseService, IEventsService
    {
        public Models.Events GetEvents(RenderingContext renderingContext)
        {
            return null;

            //var model = new Models.Events(GetDatasource(renderingContext, Events_Constants.TemplateId));

            //return model;
        }
    }
}