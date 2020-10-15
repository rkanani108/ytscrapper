using Newtonsoft.Json;
using Squidex.ClientLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace YtScraper.Models
{
    public sealed class Episode
    {
        [JsonConverter(typeof(InvariantConverter))]
        public string Title { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Location { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string StartTime { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string EndTime { get; set; }


    }
}
