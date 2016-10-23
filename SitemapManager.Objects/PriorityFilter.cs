namespace SitemapManager.Objects
{
    public class PriorityFilter
    {
        public bool IsActive { get; set; }
        public int Priority { get; set; }
        public bool IsLowerThan { get; set; }
        public bool IsHigherThan { get; set; }
        public bool IsAt { get; set; }
        public bool IsOnlyThis { get; set; }

        public PriorityFilter()
        {

        }

        public PriorityFilter(bool isActive, int priority, bool isLowerThan, bool isHigherThan, bool isAt, bool isOnlyThis)
        {
            this.IsActive = isActive;
            this.Priority = priority;
            this.IsLowerThan = isLowerThan;
            this.IsHigherThan = isHigherThan;
            this.IsAt = isAt;
            this.IsOnlyThis = isOnlyThis;
        }
    }
}
