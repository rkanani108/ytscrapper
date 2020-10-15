using Squidex.ClientLibrary;
using Squidex.ClientLibrary.Management;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using YtScraper.Models;

namespace YtScraper.Services
{
    public class ApiClient : IApiClient
    {
        [System.Obsolete]
        private SquidexClient<EpisodeEnity, Episode> episodeClient;
        [System.Obsolete]
        private SquidexClient<EpisodeCategoryEntity, EpisodeCategory> episodeCategoryClient;

        [System.Obsolete]
        public ApiClient()
        {
            var clientManager = new SquidexClientManager("http://localhost", "youtube-tv", "youtube-tv:default", "bdn1bw96jxsixpo7dx8situxililngj5wit5nopqzjsx");
            episodeClient = clientManager.GetClient<EpisodeEnity, Episode>("episode");
            episodeCategoryClient = clientManager.GetClient<EpisodeCategoryEntity, EpisodeCategory>("episode-category");
        }

        [System.Obsolete]
        public async Task<List<EpisodeEnity>> GeEpispdeAsync()
        {
            var pages = await episodeClient.GetAsync();

            return pages.Items;
        }

        [System.Obsolete]
        public async Task<List<EpisodeCategoryEntity>> GeEpispdeCategoryAsync()
        {
            var pages = await episodeCategoryClient.GetAsync();

            return pages.Items;
        }
    }
}