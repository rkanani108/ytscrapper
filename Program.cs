using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;


using YtScraper.Services;

namespace YtScraper
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
          
           builder.Services.AddSingleton<IApiClient, ApiClient>();
           
            builder.RootComponents.Add<App>("app");
          
            
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzMxNDM3QDMxMzgyZTMzMmUzMEpuSVl2TmJBa0tHZGhTaXd6Mjg4OEhXNitXYTB4RkQreGVSZHlvS3BzUUk9");
            builder.Services.AddSyncfusionBlazor();
         
            await builder.Build().RunAsync();
        }
    }
}
