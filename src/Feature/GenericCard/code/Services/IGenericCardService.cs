using Sitecore.Mvc.Presentation;
using System;

namespace Feature.GenericCard.Services
{
    public interface IGenericCardService
    {
        Models.GenericCard GetGenericCard(RenderingContext renderingContext);
    }
}
