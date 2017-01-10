using Microsoft.VisualStudio.TestTools.UnitTesting;
using SitemapManager.DAL.Data_Access;
using SitemapManager.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemapManager.Tests.Tests
{
    [TestClass]
    public class SitemapManagerTest
    {
        SitemapsManager sitemapManager = new SitemapsManager();

        /// <summary>
        /// Tests if it is truly impossible to add multiple sitemap objects with the same name
        /// </summary>
        [TestMethod]
        public void CannotCreateDuplicateUrlEntry()
        {
            // Arrange: Make 2 sitemap objects and add one to the sitemap list
            Sitemap sm1 = new Sitemap();
            sm1.LocationUrl = "http://google.com";
            Sitemap sm2 = new Sitemap();
            sm2.LocationUrl = "http://google.com";
            sitemapManager.SaveSitemapElement(sm1);

            // Act: Try to add the second item with the same URL to the list
            bool result = sitemapManager.SaveSitemapElement(sm2);

            // Assert: The result should fail
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests if it is truly impossible to add a sitemap object with no URL specified
        /// </summary>
        [TestMethod]
        public void CannotCreateEmptyUrlEntry()
        {
            // Arrange: Make a sitemap object with empty url
            Sitemap sm1 = new Sitemap();
            sm1.LocationUrl = "";

            // Act: Try to add the sitemap to the list
            bool result = sitemapManager.SaveSitemapElement(sm1);

            // Assert: The result should fail
            Assert.IsFalse(result);

        }
    }
}
