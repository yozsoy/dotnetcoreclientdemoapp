using System;

using System.Text.Json.Serialization;

namespace WebAPIClient
{
    public class Data
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("story_title")]
        public string StoryTitle { get; set; }
    }
}