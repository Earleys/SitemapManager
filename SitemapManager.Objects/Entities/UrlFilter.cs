namespace SitemapManager.DAL.Entities
{
    public class UrlFilter
    {
        public bool IsActive { get; set; }
        public string Text { get; set; }
        public bool IsContains { get; set; }
        public bool IsStartsWith { get; set; }
        public bool IsEndsWith { get; set; }

        public UrlFilter()
        {

        }

        public UrlFilter(bool isActive, string text, bool isContains, bool isStartsWith, bool isEndsWith)
        {
            this.IsActive = isActive;
            this.Text = text;
            this.IsContains = isContains;
            this.IsStartsWith = isStartsWith;
            this.IsEndsWith = isEndsWith;
        }


    }
}
