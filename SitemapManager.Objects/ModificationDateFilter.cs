using System;

namespace SitemapManager.Objects
{
    public class ModificationDateFilter
    {
        public bool IsActive { get; set; }
        public DateTime Date { get; set; }
        public bool IsBefore { get; set; }
        public bool IsAfter { get; set; }
        public bool IsAt { get; set; }
        public bool IsOnlyThis { get; set; }

        public ModificationDateFilter()
        {

        }

        public ModificationDateFilter(bool isActive, DateTime date, bool isBefore, bool isAfter, bool isAt, bool isOnlyThis)
        {
            this.IsActive = isActive;
            this.Date = date;
            this.IsBefore = isBefore;
            this.IsAfter = isAfter;
            this.IsAt = isAt;
            this.IsOnlyThis = isOnlyThis;
        }
    }
}
