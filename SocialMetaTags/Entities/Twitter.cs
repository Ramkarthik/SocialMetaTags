using HtmlAgilityPack;

namespace SocialMetaTags
{
    public class Twitter
    {
        public string Card { get; }
        public string Site { get; }
        public string SiteId { get; }
        public string Creator { get; }
        public string CreatorId { get; }
        public string Description { get; }
        public string Title { get; }
        public string Image { get; }
        public string ImageAlt { get; }
        public string Player { get; }
        public string PlayerWidth { get; }
        public string PlayerHeight { get; }
        public string PlayerStream { get; }
        public string AppNameIPhone { get; }
        public string AppIdIPhone { get; }
        public string AppUrlIPhone { get; }
        public string AppNameIPad { get; }
        public string AppIdIPad { get; }
        public string AppUrlIPad { get; }
        public string AppNameGooglePlay { get; }
        public string AppIdGooglePlay { get; }
        public string AppUrlGooglePlay { get; }


        public Twitter(HtmlNodeCollection metaTags)
        {
            foreach (var tag in metaTags)
            {
                var content = tag.Attributes["content"];
                var property = tag.Attributes["property"];
                if (property != null)
                {
                    switch (property.Value.ToLower())
                    {
                        case "twitter:card":
                            Card = content.Value;
                            break;
                        case "twitter:site":
                            Site = content.Value;
                            break;
                        case "twitter:creator":
                            Creator = content.Value;
                            break;
                        case "twitter:creator:id":
                            CreatorId = content.Value;
                            break;
                        case "twitter:description":
                            Description = content.Value;
                            break;
                        case "twitter:title":
                            Title = content.Value;
                            break;
                        case "twitter:image":
                            Image = content.Value;
                            break;
                        case "twitter:image:alt":
                            ImageAlt = content.Value;
                            break;
                        case "twitter:player":
                            Player = content.Value;
                            break;
                        case "twitter:player:width":
                            PlayerWidth = content.Value;
                            break;
                        case "twitter:player:height":
                            PlayerHeight = content.Value;
                            break;
                        case "twitter:player:stream":
                            PlayerStream = content.Value;
                            break;
                        case "twitter:app:name:iphone":
                            AppNameIPhone = content.Value;
                            break;
                        case "twitter:app:id:iphone":
                            AppIdIPhone = content.Value;
                            break;
                        case "twitter:app:url:iphone":
                            AppUrlIPhone = content.Value;
                            break;
                        case "twitter:app:name:ipad":
                            AppNameIPad = content.Value;
                            break;
                        case "twitter:app:id:ipad":
                            AppIdIPad = content.Value;
                            break;
                        case "twitter:app:url:ipad":
                            AppUrlIPad = content.Value;
                            break;
                        case "twitter:app:name:googleplay":
                            AppNameGooglePlay = content.Value;
                            break;
                        case "twitter:app:id:googleplay":
                            AppIdGooglePlay = content.Value;
                            break;
                        case "twitter:app:url:googleplay":
                            AppUrlGooglePlay = content.Value;
                            break;
                    }
                }
            }
        }
    }
}
