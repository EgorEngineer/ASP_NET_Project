using Microsoft.EntityFrameworkCore;
using Data;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Mirrra
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        void ConfigurationServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
        }
    }
}
