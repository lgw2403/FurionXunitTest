using Furion;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Invn.Web.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var env = App.HostEnvironment;
            string environmentName = env.EnvironmentName;

            services.AddFileLogging(options =>
            {
                options.FileNameRule = fileName =>
                {
                    return string.Format(fileName, DateTime.Now);
                };
            });
            services.AddFileLogging("logs/error/error-{0:yyyy}-{0:MM}-{0:dd}.log", options =>
            {
                options.FileNameRule = fileName =>
                {
                    return string.Format(fileName, DateTime.Now);
                };
                options.WriteFilter = (logMsg) =>
                {
                    return logMsg.LogLevel == LogLevel.Error;
                };
            });

            services.AddControllers().AddDynamicApiControllers().AddInjectWithUnifyResult();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseUnifyResultStatusCodes();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseInject();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}