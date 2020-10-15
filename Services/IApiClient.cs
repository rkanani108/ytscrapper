using System.Collections.Generic;
using System.Threading.Tasks;
using YtScraper.Models;

namespace YtScraper.Services
{
    public interface IApiClient
    {
        [System.Obsolete]
        Task<List<EpisodeEnity>> GeEpispdeAsync();
        [System.Obsolete]
        Task<List<EpisodeCategoryEntity>> GeEpispdeCategoryAsync();
    }
}