using SitemapManager.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemapManager
{
    public class SitemapManager
    {
        //List<Sitemap> _sitemapList = new List<Sitemap>();
        public List<Sitemap> SitemapList { get; set; }
        public List<Sitemap> SitemapListNoDuplicates { get; set; }
        public List<Sitemap> SitemapListFiltered { get; set; }

        public SitemapManager()
        {
            if (SitemapList == null)
            {
                SitemapList = new List<Sitemap>();
            }
            if (SitemapListNoDuplicates == null)
            {
                SitemapListNoDuplicates = new List<Sitemap>();
            }
            if (SitemapListFiltered == null)
            {
                SitemapListFiltered = new List<Sitemap>();
            }
        }

        public Sitemap GetSitemapElementByUrl(string name)
        {
            return SitemapList.Where(x => x.LocationUrl.ToLower() == name.ToLower()).FirstOrDefault();
        }

        public List<Sitemap> Filter(List<Sitemap> source, UrlFilter urlFilter, ModificationDateFilter modificationDateFilter, ChangeFrequencyFilter changeFrequencyFilter, PriorityFilter priorityFilter)
        {
            List<Sitemap> temporaryFilteredSitemapList = new List<Sitemap>();

            // first add everything that applies without taking other settings into account
            if (urlFilter.IsActive && urlFilter != null)
            {
                if (urlFilter.Text != null || urlFilter.Text != "")
                {
                    if (urlFilter.IsContains)
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => s.LocationUrl.ToLower().Contains(urlFilter.Text)));
                    }
                    else if (urlFilter.IsStartsWith)
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => s.LocationUrl.ToLower().StartsWith(urlFilter.Text)));
                    }
                    else if (urlFilter.IsEndsWith)
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => s.LocationUrl.ToLower().EndsWith(urlFilter.Text)));
                    }
                }
            }
            if (modificationDateFilter.IsActive && modificationDateFilter != null)
            {
                if (modificationDateFilter.IsBefore)
                {
                    if (modificationDateFilter.IsAt)
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => s.LastModified.Date <= modificationDateFilter.Date));
                    }
                    else
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => s.LastModified.Date < modificationDateFilter.Date));
                    }
                }
                else if (modificationDateFilter.IsAfter)
                {

                    if (modificationDateFilter.IsAt)
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => s.LastModified.Date >= modificationDateFilter.Date));
                    }
                    else
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => s.LastModified.Date > modificationDateFilter.Date));
                    }
                }
                else if (modificationDateFilter.IsOnlyThis)
                {
                    temporaryFilteredSitemapList.AddRange(source.Where(s => s.LastModified.Date == modificationDateFilter.Date));
                }

            }
            if (changeFrequencyFilter.IsActive && changeFrequencyFilter != null)
            {
                if (changeFrequencyFilter.IsOnlyThis)
                {
                    temporaryFilteredSitemapList.AddRange(source.Where(s => s.Frequency.ToString() == changeFrequencyFilter.Frequency));
                    temporaryFilteredSitemapList.RemoveAll(s => s.Frequency.ToString() != changeFrequencyFilter.Frequency);
                }
                else if (changeFrequencyFilter.IsEverythingButThis)
                {
                    temporaryFilteredSitemapList.AddRange(source.Where(s => s.Frequency.ToString() != changeFrequencyFilter.Frequency));
                    temporaryFilteredSitemapList.RemoveAll(s => s.Frequency.ToString() == changeFrequencyFilter.Frequency);
                }
            }
            if (priorityFilter.IsActive && priorityFilter != null)
            {
                if (priorityFilter.IsLowerThan)
                {
                    if (priorityFilter.IsAt)
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => (s.Priority * 10) <= priorityFilter.Priority));
                    }
                    else
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => (s.Priority * 10) < priorityFilter.Priority));
                    }

                }
                else if (priorityFilter.IsHigherThan)
                {
                    if (priorityFilter.IsAt)
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => (s.Priority * 10) >= priorityFilter.Priority));
                    }
                    else
                    {
                        temporaryFilteredSitemapList.AddRange(source.Where(s => (s.Priority * 10) > priorityFilter.Priority));
                    }

                }
                else if (priorityFilter.IsOnlyThis)
                {
                    temporaryFilteredSitemapList.AddRange(source.Where(s => (s.Priority * 10) == priorityFilter.Priority));
                }
            }

            // after that go through the list again, and remove everything that does not fit one or more of the other filter settings.
            // example: something added yesterday (mod. date) may have been added, but it may not have the correct name, 
            // so by going through the list again it will get filtered out anyways.
            if (urlFilter.IsActive && urlFilter != null)
            {
                if (urlFilter.IsContains)
                {
                    temporaryFilteredSitemapList.RemoveAll(s => !s.LocationUrl.ToLower().Contains(urlFilter.Text));
                }
                else if (urlFilter.IsStartsWith)
                {
                    temporaryFilteredSitemapList.RemoveAll(s => !s.LocationUrl.ToLower().StartsWith(urlFilter.Text));
                }
                else if (urlFilter.IsEndsWith)
                {
                    temporaryFilteredSitemapList.RemoveAll(s => !s.LocationUrl.ToLower().EndsWith(urlFilter.Text));
                }
            }

            if (modificationDateFilter.IsActive && modificationDateFilter != null)
            {
                if (modificationDateFilter.IsBefore)
                {
                    if (modificationDateFilter.IsAt)
                    {
                        temporaryFilteredSitemapList.RemoveAll(s => s.LastModified > modificationDateFilter.Date);
                    }
                    else
                    {
                        temporaryFilteredSitemapList.RemoveAll(s => s.LastModified >= modificationDateFilter.Date);
                    }
                }
                else if (modificationDateFilter.IsAfter)
                {
                    if (modificationDateFilter.IsAt || modificationDateFilter.IsOnlyThis)
                    {
                        temporaryFilteredSitemapList.RemoveAll(s => s.LastModified < modificationDateFilter.Date);
                    }
                    else
                    {
                        temporaryFilteredSitemapList.RemoveAll(s => s.LastModified <= modificationDateFilter.Date);
                    }
                }
                else if (modificationDateFilter.IsOnlyThis)
                {
                    temporaryFilteredSitemapList.RemoveAll(s => s.LastModified > modificationDateFilter.Date);
                    temporaryFilteredSitemapList.RemoveAll(s => s.LastModified < modificationDateFilter.Date);
                }
            }
            if (priorityFilter.IsActive && priorityFilter != null)
            {
                if (priorityFilter.IsLowerThan)
                {
                    if (priorityFilter.IsAt)
                    {
                        temporaryFilteredSitemapList.RemoveAll(s => (s.Priority * 10) > priorityFilter.Priority);
                    }
                    else
                    {
                        temporaryFilteredSitemapList.RemoveAll(s => (s.Priority * 10) >= priorityFilter.Priority);
                    }

                }
                else if (priorityFilter.IsHigherThan)
                {
                    if (priorityFilter.IsAt || priorityFilter.IsOnlyThis)
                    {
                        temporaryFilteredSitemapList.RemoveAll(s => (s.Priority * 10) < priorityFilter.Priority);
                    }
                    else
                    {
                        temporaryFilteredSitemapList.RemoveAll(s => (s.Priority * 10) <= priorityFilter.Priority);
                    }
                }
                else if (priorityFilter.IsOnlyThis)
                {
                    temporaryFilteredSitemapList.RemoveAll(s => (s.Priority * 10) > priorityFilter.Priority);
                    temporaryFilteredSitemapList.RemoveAll(s => (s.Priority * 10) < priorityFilter.Priority);
                }
            }

            return temporaryFilteredSitemapList.Distinct().ToList(); // Distinct() removes duplicates
        }
    }
}
