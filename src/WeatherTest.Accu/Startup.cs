using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherTest.Accu
{
	public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddMvc();
        }
		
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();
			app.UseMvc();
			app.UseWelcomePage();
		}
		
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
