namespace SocialMetaTags
{
    public class SocialTags
    {
        public Twitter Twitter { get; }
        public Facebook Facebook { get; }

        public SocialTags(Twitter twitter, Facebook facebook)
        {
            Twitter = twitter;
            Facebook = facebook;
        }

    }
}
