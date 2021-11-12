using System;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Text;

namespace WebAPIClient
{
    public class Program
    {
        public static IHttpClientWrapper Client { get; set; }

        public static async Task<string> Run(string author)
        {
            Book book;
            int page = 1;
            List<Data> bookData = new List<Data>();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Author: " + author);
            book = await ProcessTitles(author, page);
            bookData.AddRange(book.Data);

            int control = 0;
            while (true)
            {
                if (book.Total > bookData.Count)
                {
                    book = await ProcessTitles(author, ++page);
                    bookData.AddRange(book.Data);
                }
                else
                    break;
            }

            foreach (var data in bookData)
            {
                if (data == null)
                    continue;

                if (!string.IsNullOrEmpty(data.Title))
                {
                    sb.Append(data.Title);
                }
                else
                {
                    sb.Append(data.StoryTitle);
                }
            }
            return sb.ToString();
        }

        public static async Task Main(string[] args)
        {
            Client = new HttpClientWrapper();
            if (args == null || !args.Any())
            {
                Console.WriteLine(await Program.Run("epaga"));
            }
            else
            {
                Console.WriteLine(await Program.Run(args[0]));
            }
        }

        private static async Task<Book> ProcessTitles(string author, int page)
        {
            var streamTask = Client.GetStreamAsync("https://jsonmock.hackerrank.com/api/articles?author=" + author + "&page=" + page);
            var book = await JsonSerializer.DeserializeAsync<Book>(await streamTask);
            return book;
        }
    }
}
