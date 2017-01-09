using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Globalization;
using System.Collections;
using System.Linq;
using SitemapManager.DAL.Data_Access;
using SitemapManager.DAL.Entities;

namespace SitemapManager.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        string testSitemapPath = null;
        FileManager fileManager = new FileManager();
        List<Sitemap> sitemapList = new List<Sitemap>();

        /// <summary>
        /// Sets the file path of the example sitemap that will be used in several tests
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            // Arrange: Path to the example sitemap
            testSitemapPath = Properties.Resources.testsitemap;
        }

        /// <summary>
        /// Tests if a sitemap can be loaded by loading a pre-made file
        /// </summary>
        [TestMethod]
        public void CanLoadSitemapItems()
        { 
            // Act: Read the sitemap
            sitemapList = fileManager.ReadSiteMap(testSitemapPath);

            // Assert: Test if both elements were loaded (the example file contains 2 elements)
            Assert.AreEqual(2, sitemapList.Count);
        }

        /// <summary>
        /// Tests if a new sitemap can be added and then read by comparing it to the pre-made (correct) sitemap
        /// </summary>
        [TestMethod]
        public void CanCreateSitemapObject()
        {
            // Arrange: Add a new Sitemap element to a list containing sitemaps
            DateTime dt1;
            DateTime.TryParseExact("2025-01-01", "yyyy-mm-dd", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt1);
            dt1 = dt1.Date;
            List<Sitemap> expectedListResult = new List<Sitemap>();
            expectedListResult.Add(new Sitemap { LocationUrl = "http://www.randomwebsite.com/", Frequency = ChangeFrequency.daily, LastModified = dt1, Priority = 1.0 });

            // Act: Reads the pre-made sitemap
            sitemapList = fileManager.ReadSiteMap(testSitemapPath);

            // Assert: Tests if the newly added sitemap is equal to the pre-made file
            Assert.AreEqual(true, CheckForEquality(expectedListResult.FirstOrDefault(), sitemapList.FirstOrDefault()));
        }

        /// <summary>
        /// Checks if all commonly used sitemap elements are equal to eachother
        /// </summary>
        /// <param name="sm1">Sitemap 1</param>
        /// <param name="sm2">Sitemap 2</param>
        /// <returns>True if the sitemaps are equal to eachother</returns>
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
