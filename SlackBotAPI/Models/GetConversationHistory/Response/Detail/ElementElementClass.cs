﻿using System.Text.Json.Serialization;

namespace SlackBotAPI.Models.GetConversationHistory.Response.Detail
{
    public class ElementElementClass
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
