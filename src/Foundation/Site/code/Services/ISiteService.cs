﻿using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Foundation.Site.Services
{
    public interface ISiteService
    {
        Models.Site GetSite(RenderingContext renderingContext, Item contextItem);
    }
}
