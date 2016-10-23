using System;

namespace SitemapManager.Objects
{
    public class Sitemap
    {
        public string LocationUrl { get; set; }
        public DateTime LastModified { get; set; }
        public ChangeFrequency Frequency { get; set; }
        public double Priority { get; set; }
    }

    public enum ChangeFrequency
    {
        always,
        hourly,
        daily,
        weekly,
        monthly,
        yearly,
        never
    }
}
