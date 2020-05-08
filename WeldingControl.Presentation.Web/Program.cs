using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace WeldingControl.Presentation.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((ctx, configBuilder) =>
                {
                    configBuilder
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{ctx.HostingEnvironment.EnvironmentName}.json", optional: true,
                            reloadOnChange: true);

                    var settingsPath = Environment.GetEnvironmentVariable("SETTINGS_VOLUME");

                    if (Directory.Exists(settingsPath))
                    {
                        configBuilder.AddJsonFile($"{settingsPath}/appsettings.{ctx.HostingEnvironment.EnvironmentName}.json",
                            true, true);
                    }
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
