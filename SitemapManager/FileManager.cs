using SitemapManager.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SitemapManager
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
                } else
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
