using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPIClient
{
    public class Book
    {
        [JsonPropertyName("data")]
        public List<Data> Data { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
        
    }
}