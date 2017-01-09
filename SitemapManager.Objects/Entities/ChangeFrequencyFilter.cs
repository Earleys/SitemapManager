namespace SitemapManager.DAL.Entities
{
    public class ChangeFrequencyFilter
    {
        public bool IsActive { get; set; }
        public string Frequency { get; set; }
        public bool IsOnlyThis { get; set; }
        public bool IsEverythingButThis { get; set; }

        public ChangeFrequencyFilter()
        {

        }

        public ChangeFrequencyFilter(bool isActive, string frequency, bool isOnlyThis, bool isEverythingButThis)
        {
            this.IsActive = isActive;
            this.Frequency = frequency;
            this.IsOnlyThis = isOnlyThis;
            this.IsEverythingButThis = isEverythingButThis;
        }
    }
}
