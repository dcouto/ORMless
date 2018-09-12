namespace Foundation.Site.Factories
{
    public static class SiteFactory
    {
        public static Models.Site GetSite()
        {
            var rootPath = Sitecore.Context.Site.RootPath;

            var siteItem = Sitecore.Context.Database.GetItem(rootPath);

            return new Models.Site(siteItem);
        }
    }
}