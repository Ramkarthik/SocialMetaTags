using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace SocialMetaTags.Test
{
    [TestClass]
    public class SocialMetaTagsHelperTests
    {
        private SocialMediaTags client = new SocialMediaTags();
        
        [TestMethod]
        public async Task UrlWithSocialTags()
        {
            var url = "https://github.com/";
            var actual = await client.Tags(url);
            Assert.IsNotNull(actual);
            
            // Twitter
            Assert.IsNotNull(actual.Twitter);
            Assert.IsNotNull(actual.Twitter.Card);
            Assert.IsNotNull(actual.Twitter.Site);
            Assert.IsNotNull(actual.Twitter.Description);

            // Facebook
            Assert.IsNotNull(actual.Facebook);
            Assert.IsNotNull(actual.Facebook.Url);
            Assert.IsNotNull(actual.Facebook.SiteName);
            Assert.IsNotNull(actual.Facebook.Title);
            Assert.IsNotNull(actual.Facebook.Image);
            Assert.IsNotNull(actual.Facebook.ImageType);
            Assert.IsNotNull(actual.Facebook.ImageHeight);
            Assert.IsNotNull(actual.Facebook.ImageWidth);
            Assert.IsNotNull(actual.Facebook.Description);
        }

        [TestMethod]
        public async Task UrlWithoutSocialTags()
        {
            // Google doesn't care about social tags, so a good candidate to test
            var url = "https://google.com/";
            var actual = await client.Tags(url);
            Assert.IsNotNull(actual);

            // Twitter
            Assert.IsNotNull(actual.Twitter);
            Assert.IsNull(actual.Twitter.Card);
            Assert.IsNull(actual.Twitter.Site);
            Assert.IsNull(actual.Twitter.SiteId);
            Assert.IsNull(actual.Twitter.Creator);
            Assert.IsNull(actual.Twitter.CreatorId);
            Assert.IsNull(actual.Twitter.Title);
            Assert.IsNull(actual.Twitter.Image);
            Assert.IsNull(actual.Twitter.ImageAlt);
            Assert.IsNull(actual.Twitter.Player);
            Assert.IsNull(actual.Twitter.PlayerWidth);
            Assert.IsNull(actual.Twitter.PlayerHeight);
            Assert.IsNull(actual.Twitter.PlayerStream);
            Assert.IsNull(actual.Twitter.AppNameIPhone);
            Assert.IsNull(actual.Twitter.AppIdIPhone);
            Assert.IsNull(actual.Twitter.AppUrlIPhone);
            Assert.IsNull(actual.Twitter.AppNameIPad);
            Assert.IsNull(actual.Twitter.AppIdIPad);
            Assert.IsNull(actual.Twitter.AppUrlIPad);
            Assert.IsNull(actual.Twitter.AppNameGooglePlay);
            Assert.IsNull(actual.Twitter.AppIdGooglePlay);
            Assert.IsNull(actual.Twitter.AppUrlGooglePlay);

            // Facebook
            Assert.IsNotNull(actual.Facebook);
            Assert.IsNull(actual.Facebook.Url);
            Assert.IsNull(actual.Facebook.SiteName);
            Assert.IsNull(actual.Facebook.Title);
            Assert.IsNull(actual.Facebook.Image);
            Assert.IsNull(actual.Facebook.ImageType);
            Assert.IsNull(actual.Facebook.ImageHeight);
            Assert.IsNull(actual.Facebook.ImageWidth);
            Assert.IsNull(actual.Facebook.Description);
        }

        [TestMethod]
        public async Task InvalidUrl()
        {
            var url = "ThisIsNotAUrl";
            try
            {
                var actual = await client.Tags(url);
                // It should fail for invalid URL and not his this point
                Assert.Fail();
            }
            catch(Exception)
            {
                // If it hits catch, it is success
            }
        }
    }
}
