using SitemapManager.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemapManager.DAL.Data_Access
{
    public class SitemapsManager
    {
        //List<Sitemap> _sitemapList = new List<Sitemap>();
        /// <summary>
        /// List containing all sitemap elements
        /// </summary>
        public List<Sitemap> SitemapList { get; set; }
        /// <summary>
        /// Contains (all) sitemap elements without duplicates
        /// </summary>
        public List<Sitemap> SitemapListNoDuplicates { get; set; }
        /// <summary>
        /// Contains all filtered elements - this could be empty if nothing is filtered/found
        /// </summary>
        public List<Sitemap> SitemapListFiltered { get; set; }

        public SitemapsManager()
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

        /// <summary>
        /// Gets all sitemap elements by URL
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Single sitemap element</returns>
        public Sitemap GetSitemapElementByUrl(string name)
        {
            return SitemapList.Where(x => x.LocationUrl.ToLower() == name.ToLower()).FirstOrDefault();
        }

        /// <summary>
        /// Add a sitemap element to the list - Url has to be unique and not empty
        /// </summary>
        /// <param name="sm"></param>
        /// <returns>True if adding was succesful</returns>
        public bool SaveSitemapElement(Sitemap sm)
        {
            try
            {
                if (isUrlUnique(sm.LocationUrl) && sm.LocationUrl != null && sm.LocationUrl != "")
                {
                    SitemapList.Add(sm);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error when saving sitemap element");
                return false;
            }
        }

        /// <summary>
        /// Deletes a sitemap from the list
        /// </summary>
        /// <param name="sm"></param>
        /// <returns>True if deletion was succesful</returns>
        public bool deleteSitemapElement(Sitemap sm)
        {
            try
            {
                SitemapList.Remove(sm);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when deleting sitemap element");
                return false;
            }
        }

        /// <summary>
        /// Returns whether the item already exists in the list
        /// </summary>
        /// <param name="url"></param>
        /// <returns>True if the item does NOT exist yet</returns>
        public bool isUrlUnique(string url)
        {
            foreach (var item in SitemapList)
            {
                if (item.LocationUrl.ToLower() == url.ToLower())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Runs filter command depending on chosen user settings
        /// </summary>
        /// <param name="source">The full sitemaplist, filters will be based on this list</param>
        /// <param name="urlFilter">Url filter settings</param>
        /// <param name="modificationDateFilter">Modification filter settings</param>
        /// <param name="changeFrequencyFilter">Change frequency filter settings</param>
        /// <param name="priorityFilter">Priority filter settings</param>
        /// <returns>A custom sitemaplist containing all elements that apply to the chosen filter</returns>
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
            // example: If you're filtering on modification date and a certain name, it could've been added because it fit the date, but the name may be incorrect, 
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
