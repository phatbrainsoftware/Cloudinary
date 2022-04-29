using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using PhatBrainSoftware.Cloudinary;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTransient(sp => new CloudinaryUploadWidget(sp.GetService<IJSRuntime>()));

            await builder.Build().RunAsync();
        }
    }
}
