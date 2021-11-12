using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient
{
    public interface IHttpClientWrapper : IDisposable
    {
        Task<Stream> GetStreamAsync(string url);
    }
}
