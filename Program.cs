using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Auth0;
using Blazor.Auth0.Models.Enumerations;
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
            builder.Services.AddBlazorAuth0(options =>
            {
                options.Domain = "uwb.auth0.com";
                options.ClientId = "C7I2c6OiBj9hjtJaVkWcq4KUCJZY8TsB";
                options.RequireAuthenticatedUser = true;
            
                options.LoginMode = LoginModes.Redirect;
                //options.ClientSecret = "NEVER!!";
                //options.SlidingExpiration = true;
            });
            builder.Services.AddAuthorizationCore();
            await builder.Build().RunAsync();
        }
    }
}
