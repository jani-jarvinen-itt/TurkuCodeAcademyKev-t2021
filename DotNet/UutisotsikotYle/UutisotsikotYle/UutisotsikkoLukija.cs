using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UutisotsikotYle
{
    public class UutisotsikkoLukija
    {
        public async Task<List<string>> LueYlenPääuutisotsikot()
        {
            // vaihe 1: luetaan RSS-data
            const string YlePääuutisetUrl = "https://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss";
            HttpClient client = new();
            string xml = await client.GetStringAsync(YlePääuutisetUrl);

            // vaihe 2: käsitellään RSS-data XML-muotoisena
            XmlDocument rssXmlDoc = new();
            rssXmlDoc.LoadXml(xml);
            XmlNodeList rssElementit = rssXmlDoc.SelectNodes("rss/channel/item");

            // käydään läpi item-elementit
            List<string> otsikot = new();
            foreach (XmlNode rssElementti in rssElementit)
            {
                XmlNode rssSubNode = rssElementti.SelectSingleNode("title");
                string otsikko = rssSubNode?.InnerText ?? "(ei otsikkoa)";
                otsikot.Add(otsikko);
            }

            return otsikot;
        }
    }
}
