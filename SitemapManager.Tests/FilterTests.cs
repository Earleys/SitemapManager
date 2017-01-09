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

        [TestInitialize]
        public void Initialize()
        {
            fillFilter();
        }

        [TestMethod]
        public void NoFilterWhenNotFilteringAnything()
        {
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);
            Assert.AreEqual(0, filteredList.Count);
        }

        [TestMethod]
        public void FilterByUrlContains()
        {
            string stringToLookFor = "a";
            urlFilter = new UrlFilter(true, stringToLookFor, true, false, false);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(2, filteredList.Count);
        }

        [TestMethod]
        public void FilterByUrlStartsWith()
        {
            string stringToLookFor = "d";
            urlFilter = new UrlFilter(true, stringToLookFor, false, true, false);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FilterByUrlEndsWith()
        {
            string stringToLookFor = "f";
            urlFilter = new UrlFilter(true, stringToLookFor, false, false, true);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FilterByDateLessThanCurrent()
        {
            DateTime dateToLookFor = DateTime.Now.AddDays(-8);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, false, false);
            List <Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FilterByDateLessThanExisting()
        {
            DateTime dateToLookFor = DateTime.Now.AddDays(-15);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(0, filteredList.Count);
        }

        [TestMethod]
        public void FilterByDateEqualTo()
        {
            DateTime dateToLookFor = DateTime.Now.Date;
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, false, false, false, true);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FilterByDateHigherThanCurrent()
        {
            DateTime dateToLookFor = DateTime.Now.Date.AddDays(8);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, false, true, false, false);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FilterByDateHigherThanOrEqualToCurrent()
        {
            DateTime dateToLookFor = DateTime.Now.Date.AddDays(10);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, false, true, true, false);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FilterByChangeFrequencyEqualTo()
        {
            string changeFrequencyToLookFor = "daily";
            changeFrequencyFilter = new ChangeFrequencyFilter(true, changeFrequencyToLookFor, true, false);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(2, filteredList.Count);
        }

        [TestMethod]
        public void FilterByChangeFrequencyEverythingButThis()
        {
            string changeFrequencyToLookFor = "daily";
            changeFrequencyFilter = new ChangeFrequencyFilter(true, changeFrequencyToLookFor, false, true);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FilterByPriorityIsLowerThan()
        {
            int priorityToLookFor = 4;
            priorityFilter = new PriorityFilter(true, priorityToLookFor, true, false, false, false);
            List <Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(0, filteredList.Count);
        }

        [TestMethod]
        public void FilterByPriorityIsLowerThanOrEqualTo()
        {
            int priorityToLookFor = 4;
            priorityFilter = new PriorityFilter(true, priorityToLookFor, true, false, true, false);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(2, filteredList.Count);
        }

        [TestMethod]
        public void FilterByPriorityIsHigherThan()
        {
            int priorityToLookFor = 4;
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, true, false, false);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FilterByPriorityIsEqualTo()
        {
            int priorityToLookFor = 4;
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);
            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(2, filteredList.Count);
        }

        [TestMethod]
        public void FiltersOutNothingWithCorrectData()
        {
            string urlToLookFor = "a";
            DateTime dateToLookFor = DateTime.Now.AddDays(-10);
            string frequencyToLookFor = "daily";
            int priorityToLookFor = 4;

            urlFilter = new UrlFilter(true, urlToLookFor, true, false, false);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(1, filteredList.Count);
        }

        [TestMethod]
        public void FiltersOutWithWrongUrl()
        {
            string urlToLookFor = "b";
            DateTime dateToLookFor = DateTime.Now.AddDays(-10);
            string frequencyToLookFor = "daily";
            int priorityToLookFor = 4;

            urlFilter = new UrlFilter(true, urlToLookFor, false, true, false);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(0, filteredList.Count);
        }

        [TestMethod]
        public void FiltersOutWithWrongDate()
        {
            string urlToLookFor = "a";
            DateTime dateToLookFor = DateTime.Now.AddDays(-11);
            string frequencyToLookFor = "daily";
            int priorityToLookFor = 4;

            urlFilter = new UrlFilter(true, urlToLookFor, true, false, false);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(0, filteredList.Count);
        }

        [TestMethod]
        public void FiltersOutWithWrongFrequency()
        {
            string urlToLookFor = "a";
            DateTime dateToLookFor = DateTime.Now.AddDays(-10);
            string frequencyToLookFor = "monthly";
            int priorityToLookFor = 4;

            urlFilter = new UrlFilter(true, urlToLookFor, false, false, true);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(0, filteredList.Count);
        }

        [TestMethod]
        public void FiltersOutWithWrongPriority()
        {
            string urlToLookFor = "a";
            DateTime dateToLookFor = DateTime.Now.AddDays(-10);
            string frequencyToLookFor = "daily";
            int priorityToLookFor = 3;

            urlFilter = new UrlFilter(true, urlToLookFor, true, false, false);
            modificationDateFilter = new ModificationDateFilter(true, dateToLookFor, true, false, true, false);
            changeFrequencyFilter = new ChangeFrequencyFilter(true, frequencyToLookFor, true, false);
            priorityFilter = new PriorityFilter(true, priorityToLookFor, false, false, false, true);

            List<Sitemap> filteredList = sitemapManager.Filter(sitemapList, urlFilter, modificationDateFilter, changeFrequencyFilter, priorityFilter);

            Assert.AreEqual(0, filteredList.Count);
        }

        private void fillFilter()
        {
            sitemapList.Add(new Sitemap { LocationUrl = "abc", LastModified = DateTime.Now.AddDays(-10), Frequency = ChangeFrequency.daily, Priority = 0.4 });
            sitemapList.Add(new Sitemap { LocationUrl = "def", LastModified = DateTime.Now.Date, Frequency = ChangeFrequency.daily, Priority = 0.4 });
            sitemapList.Add(new Sitemap { LocationUrl = "afc", LastModified = DateTime.Now.AddDays(10), Frequency = ChangeFrequency.monthly, Priority = 0.6 });
        }

    }
}
