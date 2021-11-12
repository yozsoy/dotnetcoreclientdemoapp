using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient
{
    class HttpClientWrapper : IHttpClientWrapper
	{
		private readonly HttpClient HttpClient;
		public HttpClientWrapper()
		{
			HttpClient = new HttpClient();
		}
		public async Task<Stream> GetStreamAsync(string url)
		{
			HttpClient.DefaultRequestHeaders.Accept.Clear();
			HttpClient.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
			HttpClient.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
			return await HttpClient.GetStreamAsync(url);
		}
		public void Dispose()
		{
			HttpClient?.Dispose();
		}
	}
}
