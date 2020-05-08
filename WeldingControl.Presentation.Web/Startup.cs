using System.IO;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeldingControl.Business.Core;
using WeldingControl.Data.Infrastructure;
using WeldingControl.Presentation.Web.Auth;
using WeldingControl.Presentation.Web.Exceptions;

namespace WeldingControl.Presentation.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var core = Assembly.Load("WeldingControl.Business.Core");
            var auth = Configuration.GetSection("Authentication").Get<AuthenticationConfiguration>();

            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", opt =>
                {
                    opt.Authority = auth.Authority;

                    opt.Audience = auth.Audience;
                });

            services.AddDbContext<DomainContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("DefaultConnectionString")));

            services.AddMediatR(typeof(CoreAssemblyPointer).GetTypeInfo().Assembly);
            
            services.AddValidatorsFromAssembly(core);

            services.AddControllers();

            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "Client/build";
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionHandlingMiddleware>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = Path.Join(env.ContentRootPath, "Client");

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
