using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorDateRangePicker;
using Syncfusion.Blazor;
// using Blazor.LocalStorage;
// using Microsoft.JSInterop;

namespace infro.github.io
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            ConfigureServices(builder.Services, builder.HostEnvironment.BaseAddress);


            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services, IWebAssemblyHostEnvironment env, string baseAddress)
            {
                if (env.IsDevelopment())
                {
                    
                }
                Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzMzMjc1QDMyMzAyZTMzMmUzMFpnbW9YY2M3RW8xcHo0OXpmcm04MXovaXlPbDZPN2ZGZHlGK0pXQ1pKbTQ9");

                services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });
                services.AddDateRangePicker(config => {
                    config.TimePicker = true;
                    config.TimePickerIncrement = 30;
                    config.TimePickerSeconds = false;
                    config.MinSpan = TimeSpan.FromHours(1.5);
                });
                services.AddSyncfusionBlazor(options =>
                {
                    // options.Animation = GlobalAnimationMode.Default;
                    // options.EnableRippleEffect = true;
                    // options.EnableRtl = false; //Right to Left
                    // options.IgnoreScriptIsolation = true;
                });
                services.AddLocalStorageServices();
                //TODO: Static Files To Read: https://learn.microsoft.com/en-us/aspnet/core/blazor/host-and-deploy/webassembly-deployment-layout?view=aspnetcore-6.0
                // services.AddLogging(logger => logger.AddProvider(serilog));
                //https://habr.com/en/post/591171/
            }
    }
}
