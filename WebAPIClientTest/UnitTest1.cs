using Moq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using WebAPIClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using FluentAssertions;

namespace WebAPIClientTest
{
    public class UnitTest1
    {
        List<string> data = new List<string>();

        #region Tests
        [Fact]
        public void Coloneltcb_2_pages_14_element_Test()
        {
            data.Add("https://jsonmock.hackerrank.com/api/articles?author=coloneltcb&page=1");
            data.Add("{\"page\":1,\"per_page\":10,\"total\":14,\"total_pages\":2,\"data\":[{\"title\":\"Paul Allen has died\",\"url\":\"https://www.cnbc.com/2018/10/15/microsoft-co-founder-paul-allen-dies-of-cancer-at-age-65.html\",\"author\":\"coloneltcb\",\"num_comments\":277,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1539640814},{\"title\":\"No Thank You, Mr. Pecker\",\"url\":\"https://medium.com/@jeffreypbezos/no-thank-you-mr-pecker-146e3922310f\",\"author\":\"coloneltcb\",\"num_comments\":730,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1549579936},{\"title\":\"Uber Paid Hackers to Delete Stolen Data on 57M People\",\"url\":\"https://www.bloomberg.com/news/articles/2017-11-21/uber-concealed-cyberattack-that-exposed-57-million-people-s-data\",\"author\":\"coloneltcb\",\"num_comments\":572,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1511301725},{\"title\":\"Facebook Network Breach Impacts Up to 50M Users\",\"url\":\"https://www.nytimes.com/2018/09/28/technology/facebook-hack-data-breach.html\",\"author\":\"coloneltcb\",\"num_comments\":609,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1538153229},{\"title\":\"Leonard Nimoy, Spock of ‘Star Trek,’ Dies at 83\",\"url\":\"http://www.nytimes.com/2015/02/27/arts/television/leonard-nimoy-spock-of-star-trek-dies-at-83.html?smid=tw-bna\",\"author\":\"coloneltcb\",\"num_comments\":165,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1425057162},{\"title\":\"Obama Commutes Bulk of Chelsea Manning’s Sentence\",\"url\":\"https://www.nytimes.com/2017/01/17/us/politics/obama-commutes-bulk-of-chelsea-mannings-sentence.html?_r=0\",\"author\":\"coloneltcb\",\"num_comments\":713,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1484687885},{\"title\":\"Apple has pushed a silent Mac update to remove hidden Zoom web server\",\"url\":\"https://techcrunch.com/2019/07/10/apple-silent-update-zoom-app/\",\"author\":\"coloneltcb\",\"num_comments\":532,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1562797504},{\"title\":\"Uber's playbook for sabotaging Lyft\",\"url\":\"http://www.theverge.com/2014/8/26/6067663/this-is-ubers-playbook-for-sabotaging-lyft\",\"author\":\"coloneltcb\",\"num_comments\":391,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1409082197},{\"title\":\"Silicon Valley Women, in Cultural Shift, Frankly Describe Sexual Harassment\",\"url\":\"https://www.nytimes.com/2017/06/30/technology/women-entrepreneurs-speak-out-sexual-harassment.html?_r=0\",\"author\":\"coloneltcb\",\"num_comments\":730,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1498859192},{\"title\":\"AMP for email is a terrible idea\",\"url\":\"https://techcrunch.com/2018/02/13/amp-for-email-is-a-terrible-idea/\",\"author\":\"coloneltcb\",\"num_comments\":465,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1518567466}]}");
            data.Add("https://jsonmock.hackerrank.com/api/articles?author=coloneltcb&page=2");
            data.Add("{\"page\":2,\"per_page\":10,\"total\":14,\"total_pages\":2,\"data\":[{\"title\":null,\"url\":null,\"author\":\"coloneltcb\",\"num_comments\":764,\"story_id\":null,\"story_title\":\"How Uber Used Secret “Greyball” Tool to Deceive Authorities Worldwide\",\"story_url\":\"https://www.nytimes.com/2017/03/03/technology/uber-greyball-program-evade-authorities.html?_r=0\",\"parent_id\":null,\"created_at\":1488569681},{\"title\":\"FTC Probing Facebook for Use of Personal Data, Source Says\",\"url\":\"https://www.bloomberg.com/news/articles/2018-03-20/ftc-said-to-be-probing-facebook-for-use-of-personal-data\",\"author\":\"coloneltcb\",\"num_comments\":371,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1521552658},{\"title\":\"WhatsApp co-founder tells everyone to delete Facebook\",\"url\":\"https://www.theverge.com/2018/3/20/17145200/brian-acton-delete-facebook-whatsapp\",\"author\":\"coloneltcb\",\"num_comments\":628,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1521588274},{\"title\":\"Hijack of Amazon’s domain service used to reroute web traffic for two hours\",\"url\":\"https://doublepulsar.com/hijack-of-amazons-internet-domain-service-used-to-reroute-web-traffic-for-two-hours-unnoticed-3a6f0dda6a6f\",\"author\":\"coloneltcb\",\"num_comments\":284,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1524591279}]}");
            Setup(data);
            var result = Program.Run("coloneltcb").Result;
            result.Should().Be("Paul Allen has diedNo Thank You, Mr. PeckerUber Paid Hackers to Delete Stolen Data on 57M PeopleFacebook Network Breach Impacts Up to 50M UsersLeonard Nimoy, Spock of ‘Star Trek,’ Dies at 83Obama Commutes Bulk of Chelsea Manning’s SentenceApple has pushed a silent Mac update to remove hidden Zoom web serverUber's playbook for sabotaging LyftSilicon Valley Women, in Cultural Shift, Frankly Describe Sexual HarassmentAMP for email is a terrible ideaHow Uber Used Secret “Greyball” Tool to Deceive Authorities WorldwideFTC Probing Facebook for Use of Personal Data, Source SaysWhatsApp co-founder tells everyone to delete FacebookHijack of Amazon’s domain service used to reroute web traffic for two hours");
        }

        [Fact]
        public void Pkiller_1_page_4_element_Test()
        {
            data.Add("https://jsonmock.hackerrank.com/api/articles?author=pkiller&page=1");
            data.Add("{\"page\":1,\"per_page\":10,\"total\":4,\"total_pages\":1,\"data\":[{\"title\":\"Show HN: A retro video game console I've been working on in my free time\",\"url\":\"https://internalregister.github.io/2019/03/14/Homebrew-Console.html\",\"author\":\"pkiller\",\"num_comments\":210,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1552595103},{\"title\":\"Don't Fly During Ramadan\",\"url\":\"http://varnull.adityamukerjee.net/post/59021412512/dont-fly-during-ramadan\",\"author\":\"pkiller\",\"num_comments\":961,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1377191457},{\"title\":\"Pardon Snowden\",\"url\":\"https://www.pardonsnowden.org/\",\"author\":\"pkiller\",\"num_comments\":781,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1473841875},{\"title\":\"Chrome 69 will keep Google Cookies when you tell it to delete all cookies\",\"url\":\"https://twitter.com/ctavan/status/1044282084020441088\",\"author\":\"pkiller\",\"num_comments\":810,\"story_id\":null,\"story_title\":null,\"story_url\":null,\"parent_id\":null,\"created_at\":1537864744}]}");
            Setup(data);
            var result = Program.Run("pkiller").Result;
            result.Should().Be("Show HN: A retro video game console I've been working on in my free timeDon't Fly During RamadanPardon SnowdenChrome 69 will keep Google Cookies when you tell it to delete all cookies");
        }

        [Fact]
        public void Empty_data_test()
        {
            data.Add("https://jsonmock.hackerrank.com/api/articles?author=mpweiher&page=1");
            data.Add( "{ \"page\": 1, \"per_page\": 10, \"total\": 0, \"total_pages\": 1, \"data\": [ ] }" );
            Setup(data);
            var result = Program.Run("mpweiher").Result;
            result.Should().Be("");
        }

        [Fact]
        public void Empty_title_test()
        {
            data.Add("https://jsonmock.hackerrank.com/api/articles?author=guelo&page=1");
            data.Add("{ \"page\": 1, \"per_page\": 10, \"total\": 2, \"total_pages\": 1, \"data\": [ { \"title\": \"\", \"url\": \"https://internalregister.github.io/2019/03/14/Homebrew-Console.html\", \"author\": \"pkiller\", \"num_comments\": 210, \"story_id\": null, \"story_title\": \"qwer tyu\", \"story_url\": null, \"parent_id\": null, \"created_at\": 1552595103 },{ \"title\": \"\", \"url\": \"https://internalregister.github.io/2019/03/14/Homebrew-Console.html\", \"author\": \"pkiller\", \"num_comments\": 210, \"story_id\": null, \"story_title\": \"qwer tyu2\", \"story_url\": null, \"parent_id\": null, \"created_at\": 1552595103 } ] }");
            Setup(data);
            var result = Program.Run("guelo").Result;
            result.Should().Be("qwer tyuqwer tyu2");
        }
        [Fact]
        public void Null_title_mix_test()
        {
            data.Add("https://jsonmock.hackerrank.com/api/articles?author=frederfred&page=1");
            data.Add("{ \"page\": 1, \"per_page\": 10, \"total\": 2, \"total_pages\": 1, \"data\": [ { \"title\": \"title1\", \"url\": \"https://internalregister.github.io/2019/03/14/Homebrew-Console.html\", \"author\": \"pkiller\", \"num_comments\": 210, \"story_id\": null, \"story_title\": \"story title 1\", \"story_url\": null, \"parent_id\": null, \"created_at\": 1552595103 },{ \"title\": null, \"url\": \"https://internalregister.github.io/2019/03/14/Homebrew-Console.html\", \"author\": \"pkiller\", \"num_comments\": 210, \"story_id\": null, \"story_title\": \"story title 2\", \"story_url\": null, \"parent_id\": null, \"created_at\": 1552595103 } ] }");
            Setup(data);
            var result = Program.Run("frederfred").Result;
            result.Should().Be("title1story title 2");
        }
        [Fact]
        public void Exception_test()
        {
            data.Add("https://jsonmock.hackerrank.com/api/articles?author=vladikoff&page=1");
            data.Add("{ \"page\": 1, \"per_page\": 10, \"total\": 1000, \"total_pages\": 1, \"data\": [ { \"title\": \"title1\", \"url\": \"https://internalregister.github.io/2019/03/14/Homebrew-Console.html\", \"author\": \"pkiller\", \"num_comments\": 210, \"story_id\": null, \"story_title\": \"story title 1\", \"story_url\": null, \"parent_id\": null, \"created_at\": 1552595103 },{ \"title\": null, \"url\": \"https://internalregister.github.io/2019/03/14/Homebrew-Console.html\", \"author\": \"pkiller\", \"num_comments\": 210, \"story_id\": null, \"story_title\": \"story title 2\", \"story_url\": null, \"parent_id\": null, \"created_at\": 1552595103 } ] }");
            Setup(data);
            Assert.Throws<AggregateException>(() => Program.Run("vladikoff").Result);
        }
        #endregion

        #region Private Methods
        private Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
        private void Setup(List<string> data)
        {
            Mock<IHttpClientWrapper> mockClient = new Mock<IHttpClientWrapper>();
            for (int i = 0; i < data.Count; i = i + 2)
            {
                string input = data[i];
                string output = data[i + 1];
                mockClient.Setup(x => x.GetStreamAsync(input)).Returns(Task.FromResult(GenerateStreamFromString(output)));
            }
            Program.Client = mockClient.Object;
        }
        #endregion
    }
}
