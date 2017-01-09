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
        /// <returns>XElement</returns>
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
        /// Attempts to generate and 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sitemapList"></param>
        /// <returns></returns>
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

            //XNamespace xNamespaceInstance = "http://www.w3.org/2001/XMLSchema-instance";

            //XDocument xDoc = new XDocument(
            //      new XDeclaration("1.0", "UTF-8", "no"),
            //new XElement(xNamespace + "urlset",
            //new XAttribute(XNamespace.Xmlns + "xsi", xNamespaceInstance),
            //new XAttribute(xNamespaceInstance + "schemaLocation",
            //    "http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd")
            //    ));


            //foreach (var item in sitemapList)
            //{
            //    XElement root = new XElement("url");
            //    root.Add(new XAttribute("loc", item.LocationUrl));
            //    root.Add(new XAttribute("lastmod", item.LastModified));
            //    root.Add(new XAttribute("changefreq", item.Frequency));
            //    root.Add(new XAttribute("priority", item.Priority));
            //}
            //xDoc.Save(path);
            //result = true;
        

        }

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
