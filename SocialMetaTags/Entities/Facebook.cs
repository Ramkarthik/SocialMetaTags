using HtmlAgilityPack;

namespace SocialMetaTags
{
    public class Facebook
    {
        public string Url { get; }
        public string Title { get; }
        public string SiteName { get; }
        public string Description { get; }
        public string Image { get; }
        public string ImageType { get; }
        public string ImageHeight { get; }
        public string ImageWidth { get; }
        public string AppId { get; }
        public string Type { get; }
        public string Locale { get; }

        public Facebook(HtmlNodeCollection metaTags)
        {
            foreach (var tag in metaTags)
            {
                var content = tag.Attributes["content"];
                var property = tag.Attributes["property"];
                if (property != null)
                {
                    switch (property.Value.ToLower())
                    {
                        case "og:url":
                            Url = content.Value;
                            break;
                        case "og:title":
                            Title = content.Value;
                            break;
                        case "og:site_name":
                            SiteName = content.Value;
                            break;
                        case "og:description":
                            Description = content.Value;
                            break;
                        case "og:image":
                            Image = content.Value;
                            break;
                        case "og:image:type":
                            ImageType = content.Value;
                            break;
                        case "og:image:width":
                            ImageWidth = content.Value;
                            break;
                        case "og:image:height":
                            ImageHeight = content.Value;
                            break;
                        case "fb:app_id":
                            AppId = content.Value;
                            break;
                        case "og:type":
                            Type = content.Value;
                            break;
                        case "og:locale":
                            Locale = content.Value;
                            break;
                    }
                }
            }
        }
    }
}
