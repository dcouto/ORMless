﻿using Sitecore.Mvc.Presentation;

namespace Foundation.NavigationLink.Services
{
    public interface INavigationLinkService
    {
        Models.NavigationLink GetNavigationLink(RenderingContext renderingContext);
    }
}