using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeldingControl.Shared.Constants;

namespace IdentityServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var roleManager = scope.ServiceProvider
                    .GetRequiredService<RoleManager<IdentityRole>>();

                Task.WaitAll(roleManager.CreateAsync(new IdentityRole(Roles.Welder)),
                    roleManager.CreateAsync(new IdentityRole(Roles.Master)),
                    roleManager.CreateAsync(new IdentityRole(Roles.Supervisor)));

                var userManager = scope.ServiceProvider
                    .GetRequiredService<UserManager<IdentityUser>>();

                var dgoncharov = new IdentityUser("dgoncharov");
                var alozikov = new IdentityUser("alozikov");
                var apusovsky = new IdentityUser("apusovsky");
                var szaichenko = new IdentityUser("szaichenko");

                Task.WaitAll(userManager.CreateAsync(dgoncharov, "dgoncharov"),
                    userManager.AddToRoleAsync(dgoncharov, Roles.Welder));

                Task.WaitAll(userManager.CreateAsync(alozikov, "alozikov"),
                    userManager.AddToRoleAsync(alozikov, Roles.Welder));

                Task.WaitAll(userManager.CreateAsync(apusovsky, "apusovsky"),
                    userManager.AddToRoleAsync(apusovsky, Roles.Welder));

                Task.WaitAll(userManager.CreateAsync(szaichenko, "szaichenko"),
                    userManager.AddToRoleAsync(szaichenko, Roles.Master));
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
