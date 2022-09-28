using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
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

            static void ConfigureServices(IServiceCollection services, string baseAddress)
            {
                services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });
            }
        }
    }
}