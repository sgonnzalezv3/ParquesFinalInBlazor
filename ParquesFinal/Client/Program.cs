using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ParquesFinal.Client.Repositorios;
using Tewr.Blazor.FileReader;
using Microsoft.AspNetCore.Components.Authorization;
using ParquesFinal.Client.Auth;

namespace ParquesFinal.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            ConfigureServices(builder.Services);
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions(); // Sistema de autorizacon
            services.AddScoped<IRepositorio, Repositorio>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
            services.AddAuthorizationCore();
            services.AddScoped<ProveedeorAutenticacionJWT>();
            services.AddScoped<AuthenticationStateProvider, ProveedeorAutenticacionJWT>(
    provider => provider.GetRequiredService<ProveedeorAutenticacionJWT>()
    );
            services.AddScoped<ILoginService, ProveedeorAutenticacionJWT>(
                provider => provider.GetRequiredService<ProveedeorAutenticacionJWT>()
                );
        }
    }
}
