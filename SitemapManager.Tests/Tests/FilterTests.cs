using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SitemapManager.DAL.Entities;
using SitemapManager.DAL.Data_Access;

namespace SitemapManager.Tests
{
    [TestClass]
    public class FilterTests
    {
        // everything is disabled by default:
        UrlFilter urlFilter = new UrlFilter(false, "", false, false, false);
        ModificationDateFilter modificationDateFilter = new ModificationDateFilter(false, DateTime.MinValue, false, false, false, false);
        ChangeFrequencyFilter changeFrequencyFilter = new ChangeFrequencyFilter(false, "", false, false);
        PriorityFilter priorityFilter = new PriorityFilter(false, 0, false, false, false, false);
        List<Sitemap> sitemapList = new List<Sitemap>();
       

        Sitemap sitemap = new Sitemap();
        SitemapsManager sitemapManager = new SitemapsManager();

        /// <summary>
        /// Fills a example sitemap list with a few sitemap objects, so the filters can be tested. Used in several tests.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            // Arrange: fills the sitemaplist with example sitemap objects
            fillFilter();
        }

        /// <summary>
        /// Tests if the filter list remains empty if nothing is filtered 
        /// </summary>
        [TestMethod]
        public void NoFilterWhenNotFilteringAnything()
        {
            // Act: Tries to filter with all filters disabled
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Assert: Tests if the list is empty (since nothing is filtered)
            Assert.AreEqual(0, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter returns all elements that contain a certain string
        /// </summary>
        [TestMethod]
        public void FilterByUrlContains()
        {
            // Arrange: Sets the string to look for, and changes the filter settings
            string stringToLookFor = "a";
            urlFilter = new UrlFilter(true, stringToLookFor, true, false, false);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements containing an 'a'
            Assert.AreEqual(2, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements that start with 'd'
        /// </summary>
        [TestMethod]
        public void FilterByUrlStartsWith()
        {
            // Arrange: Sets the string to look for, and changes the filter settings
            string stringToLookFor = "d"; 
            urlFilter = new UrlFilter(true, stringToLookFor, false, true, false);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements that start with a 'd'
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements that end with 'f'
        /// </summary>
        [TestMethod]
        public void FilterByUrlEndsWith()
        {
            // Arrange: Sets the string to look for, and changes the filter settings
            string stringToLookFor = "f";
            urlFilter = new UrlFilter(true, stringToLookFor, false, false, true);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements that start with a 'd'
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a date earlier than a certain date/Time
        /// </summary>
        [TestMethod]
        public void FilterByDateLessThanCurrent()
        {
            // Arrange: Sets a date to look for, and changes the filter settings
            DateTime dateToLookFor = DateTime.Now.AddDays(-8);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, false, false);

            // Act: Applies the filter
            List <Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements before chosen date/time
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a date earlier than what exists (should be 0)
        /// </summary>
        [TestMethod]
        public void FilterByDateLessThanExisting()
        {
            // Arrange: Sets a date to look for, and changes the filter settings
            DateTime dateToLookFor = DateTime.Now.AddDays(-15);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains 0 elements
            Assert.AreEqual(0, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a date equal to now
        /// </summary>
        [TestMethod]
        public void FilterByDateEqualTo()
        {
            // Arrange: Sets a date to look for, and changes the filter settings
            DateTime dateToLookFor = DateTime.Now.Date;
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, false, false, false, true);

            // Act: applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a date equal to now
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a date higher than now
        /// </summary>
        [TestMethod]
        public void FilterByDateHigherThanCurrent()
        {
            // Arrange: Sets a date to look for, and changes the filter settings
            DateTime dateToLookFor = DateTime.Now.Date.AddDays(8);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, false, true, false, false);

            // Act: applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a date equal to now
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a date higher and/or equal to now
        /// </summary>
        [TestMethod]
        public void FilterByDateHigherThanOrEqualToCurrent()
        {
            // Arrange: Sets a date to look for, and changes the filter settings
            DateTime dateToLookFor = DateTime.Now.Date.AddDays(10);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, false, true, true, false);

            // Act: applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a date equal to now
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a change frequency equal to the chosen value
        /// </summary>
        [TestMethod]
        public void FilterByChangeFrequencyEqualTo()
        {
            // Arrange: Sets a change frequency to look for, and changes the filter settings
            string changeFrequencyToLookFor = "daily";
            changeFrequencyFilter = new ChangeFrequencyFilter(true, changeFrequencyToLookFor, true, false);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a change Frequency equal to daily
            Assert.AreEqual(2, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elementst with a change frequency equal to everything but the chosen value
        /// </summary>
        [TestMethod]
        public void FilterByChangeFrequencyEverythingButThis()
        {
            // Arrange: Sets a change frequency to NOT look for, and changes the filter settings
            string changeFrequencyToLookFor = "daily";
            changeFrequencyFilter = new ChangeFrequencyFilter(true, changeFrequencyToLookFor, false, true);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a change frequency not to daily
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a priority lower than the chosen value
        /// </summary>
        [TestMethod]
        public void FilterByPriorityIsLowerThan()
        {
            // Arrange: Sets a priority, and changes the filter settings
            int priorityToLookFor = 4;
            priorityFilter = new PriorityFilter(true, priorityToLookFor, true, false, false, false);

            // Act: Applies the filter
            List <Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a priority lower than 4
            Assert.AreEqual(0, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a priority lower than or equal to the chosen value
        /// </summary>
        [TestMethod]
        public void FilterByPriorityIsLowerThanOrEqualTo()
        {
            ///Arrange: Sets a priority, and changes the filter settings
            int priorityToLookFor = 4;
            priorityFilter = new PriorityFilter(true, priorityToLookFor, true, false, true, false);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a priority lower than or equal to 4
            Assert.AreEqual(2, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a priority higher than the chosen value
        /// </summary>
        [TestMethod]
        public void FilterByPriorityIsHigherThan()
        {
            /// Arrange: Sets a priority, and changes the filter settings
            int priorityToLookFor = 4;
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, true, false, false);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a priority higer than 4
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if the filter can return all elements with a priority equal to the chosen value
        /// </summary>
        [TestMethod]
        public void FilterByPriorityIsEqualTo()
        {
            /// Arrange: Sets a priority, and changes the filter settings
            int priorityToLookFor = 4;
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if the list contains all elements with a priority equal to 4
            Assert.AreEqual(2, filteredList.Count);
        }

        /// <summary>
        /// Tests if things won't get filtered out(/overwritten) if every filter setting is met
        /// </summary>
        [TestMethod]
        public void FiltersOutNothingWithCorrectData()
        {
            // Arrange: Sets the different settings and applies the different filters
            string urlToLookFor = "a";
            DateTime dateToLookFor = DateTime.Now.AddDays(-10);
            string frequencyToLookFor = "daily";
            int priorityToLookFor = 4;
            urlFilter = new UrlFilter(true, urlToLookFor, true, false, false);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            // Act: Applies the filters
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if there's still an element found
            Assert.AreEqual(1, filteredList.Count);
        }

        /// <summary>
        /// Tests if things will get filtered out if url-setting isn't met when others are
        /// </summary>
        [TestMethod]
        public void FiltersOutWithWrongUrl()
        {
            // Arrange: Sets the different settings and applies the different filters
            string urlToLookFor = "b";
            DateTime dateToLookFor = DateTime.Now.AddDays(-10);
            string frequencyToLookFor = "daily";
            int priorityToLookFor = 4;
            urlFilter = new UrlFilter(true, urlToLookFor, false, true, false);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if nothing is found
            Assert.AreEqual(0, filteredList.Count);
        }

        /// <summary>
        /// Tests if things will get filtered out if date-setting isn't met and others are
        /// </summary>
        [TestMethod]
        public void FiltersOutWithWrongDate()
        {
            // Arrange: Sets the different settings and applies the different filters
            string urlToLookFor = "a";
            DateTime dateToLookFor = DateTime.Now.AddDays(-11);
            string frequencyToLookFor = "daily";
            int priorityToLookFor = 4;
            urlFilter = new UrlFilter(true, urlToLookFor, true, false, false);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if nothing is found
            Assert.AreEqual(0, filteredList.Count);
        }

        /// <summary>
        /// Tests if things will get filtered out if Frequency-setting isn't met and others are
        /// </summary>
        [TestMethod]
        public void FiltersOutWithWrongFrequency()
        {
            // Arrange: Arrange: Sets the different settings and applies the different filters
            string urlToLookFor = "a";
            DateTime dateToLookFor = DateTime.Now.AddDays(-10);
            string frequencyToLookFor = "monthly";
            int priorityToLookFor = 4;
            urlFilter = new UrlFilter(true, urlToLookFor, false, false, true);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if nothing is found
            Assert.AreEqual(0, filteredList.Count);
        }

        /// <summary>
        /// Tests if things will get filtered out if Priority-setting isn't met and others are
        /// </summary>
        [TestMethod]
        public void FiltersOutWithWrongPriority()
        {
            // Arrange: Arrange: Sets the different settings and applies the different filters
            string urlToLookFor = "a";
            DateTime dateToLookFor = DateTime.Now.AddDays(-10);
            string frequencyToLookFor = "daily";
            int priorityToLookFor = 3;
            urlFilter = new UrlFilter(true, urlToLookFor, true, false, false);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            // Act: Applies the filter
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            // Arrange: Tests if nothing is found
            Assert.AreEqual(0, filteredList.Count);
        }

        /// <summary>
        /// Fills the sitemap list with dummy sitemap items
        /// </summary>
        private void fillFilter()
        {
            sitemapList.Add(new Sitemap { LocationUrl = "abc", LastModified = DateTime.Now.AddDays(-10), Frequency = ChangeFrequency.daily, Priority = 0.4 });
            sitemapList.Add(new Sitemap { LocationUrl = "def", LastModified = DateTime.Now.Date, Frequency = ChangeFrequency.daily, Priority = 0.4 });
            sitemapList.Add(new Sitemap { LocationUrl = "afc", LastModified = DateTime.Now.AddDays(10), Frequency = ChangeFrequency.monthly, Priority = 0.6 });
        }

    }
}
