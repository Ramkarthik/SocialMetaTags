using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SocialMetaTags
{
    public class SocialMediaTags
    {
        private static HtmlWeb client = new HtmlWeb();
        public async Task<SocialTags> Tags(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException("Invalid URL input");

            var html = await client.LoadFromWebAsync(url);
            var metaTags = html.DocumentNode.SelectNodes("//meta");
            var twitter = new Twitter(metaTags);
            var facebook = new Facebook(metaTags);
            var socialTags = new SocialTags(twitter: twitter, facebook: facebook);

            return socialTags;
        }
    }
}
