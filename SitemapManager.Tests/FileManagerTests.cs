using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Globalization;
using System.Collections;
using System.Linq;
using SitemapManager.DAL.Entities;
using SitemapManager.DAL.Data_Access;

namespace SitemapManager.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        string testSitemapPath = null;
        FileManager fileManager = new FileManager();
        List<Sitemap> sitemapList = new List<Sitemap>();

        [TestInitialize]
        public void Initialize()
        {
            testSitemapPath = Properties.Resources.testsitemap;
        }

        [TestMethod]
        public void CanLoadSitemapItems()
        {
            sitemapList = fileManager.ReadSiteMap(testSitemapPath);
            Assert.AreEqual(2, sitemapList.Count);
        }

        [TestMethod]
        public void CanCreateSitemapObject()
        {
            DateTime dt1;
            DateTime.TryParseExact("2025-01-01", "yyyy-mm-dd", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt1);
            dt1 = dt1.Date;

            List<Sitemap> expectedListResult = new List<Sitemap>();
            expectedListResult.Add(new Sitemap { LocationUrl = "http://www.randomwebsite.com/", Frequency = ChangeFrequency.daily, LastModified = dt1, Priority = 1.0 });

            sitemapList = fileManager.ReadSiteMap(testSitemapPath);
            Assert.AreEqual(true, CheckForEquality(expectedListResult.FirstOrDefault(), sitemapList.FirstOrDefault()));
        }

        private bool CheckForEquality(Sitemap sm1, Sitemap sm2)
        {
            bool result = false;

                    result = sm1.LocationUrl.ToLower() == sm2.LocationUrl.ToLower()
                        && sm1.LastModified.Date == sm2.LastModified.Date
                        && sm1.Frequency.ToString().ToLower() == sm2.Frequency.ToString().ToLower()
                        && sm1.Priority == sm2.Priority
                        ? true : false;        
            
            return result;
        }
    }
}
