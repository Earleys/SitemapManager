using SitemapManager.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SitemapManager.DAL.Data_Access
{
    public class FileManager
    {
        /// <summary>
        /// Reads a sitemap (XML file) from the chosen path
        /// </summary>
        /// <param name="path">Path to a Sitemap XML file</param>
        /// <returns>Returns a list of Sitemap elements</returns>
        public List<Sitemap> ReadSiteMap(string path)
        {
            try
            {
                List<Sitemap> smList = new List<Sitemap>();
                FileStream fs = null;
                XDocument xDoc = null;
                if (IsValidPath(path))
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    xDoc = XDocument.Load(fs);
                }
                else
                {
                    xDoc = XDocument.Parse(path);
                }



                var ns = XNamespace.Get("http://www.sitemaps.org/schemas/sitemap/0.9"); // namespace is required to get the correct field
                var units = from u in xDoc.Root.Descendants(ns + "url")
                            select new
                            {
                                Loc = (string)u.Element(ns + "loc"),
                                LastMod = (DateTime)u.Element(ns + "lastmod"),
                                ChangeFreq = (ChangeFrequency)Enum.Parse(typeof(ChangeFrequency), (string)u.Element(ns + "changefreq"), true),
                                Priority = (double)u.Element(ns + "priority")
                            };

                foreach (var unit in units)
                {
                    Sitemap sm = new Sitemap();
                    sm.LocationUrl = unit.Loc;
                    sm.LastModified = unit.LastMod;
                    sm.Frequency = unit.ChangeFreq;
                    sm.Priority = unit.Priority;
                    smList.Add(sm);
                }

                return smList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when reading sitemap: " + ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Generates a sitemap
        /// </summary>
        /// <param name="sitemapList"></param>
        /// <returns>XElement or null on error</returns>
        public XElement GenerateSitemap(List<Sitemap> sitemapList)
        {
            XElement root = null;
            try
            {
                // http://rehansaeed.com/dynamically-generating-sitemap-xml-for-asp-net-mvc/
                XNamespace xNamespace = "http://www.sitemaps.org/schemas/sitemap/0.9";
                root = new XElement(xNamespace + "urlset");

                foreach (Sitemap sitemap in sitemapList)
                {
                    XElement urlElement = new XElement(xNamespace + "url",  // url

                        new XElement(xNamespace + "loc", Uri.EscapeUriString(sitemap.LocationUrl)),     // loc

                        sitemap.LastModified == null ? null : new XElement(      // lastModified
                            xNamespace + "lastmod",
                            sitemap.LastModified.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:sszzz")),

                        new XElement(    //changeFreq
                            xNamespace + "changefreq",
                            sitemap.Frequency.ToString().ToLowerInvariant()),

                        new XElement(    // Priority
                            xNamespace + "priority",
                            sitemap.Priority.ToString("F1", CultureInfo.InvariantCulture)));

                    root.Add(urlElement);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error in FileManager/GenerateSitemap(List<>): " + e.Message);
            }

            return root;
        }

        /// <summary>
        /// Attempts to save a sitemap element
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sitemapElements"></param>
        /// <returns>Whether save was succesful</returns>
        public bool SaveSitemap(string path, XElement sitemapElements)
        {
            // if no elements were added
            if (sitemapElements == null)
            {
                return false;
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(sitemapElements);
            }

            return true;

        

        }

        /// <summary>
        /// Checks if the path is valid
        /// </summary>
        /// <param name="path"></param>
        /// <returns>True if path is valid</returns>
    private bool IsValidPath(string path)
    {
        Regex driveCheck = new Regex(@"^[a-zA-Z]:\\$");
        if (!driveCheck.IsMatch(path.Substring(0, 3))) return false;
        string strTheseAreInvalidFileNameChars = new string(Path.GetInvalidPathChars());
        strTheseAreInvalidFileNameChars += @":/?*" + "\"";
        Regex containsABadCharacter = new Regex("[" + Regex.Escape(strTheseAreInvalidFileNameChars) + "]");
        if (containsABadCharacter.IsMatch(path.Substring(3, path.Length - 3)))
            return false;

        return true;
    }
}
}
