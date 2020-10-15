using Newtonsoft.Json;
using Squidex.ClientLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace YtScraper.Models
{
    public sealed class EpisodeCategory
    {
        [JsonConverter(typeof(InvariantConverter))]
        public string Name { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Color { get; set; }

      
    }
}
