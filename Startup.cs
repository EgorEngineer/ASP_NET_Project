using Microsoft.EntityFrameworkCore;
using Mirrra;

namespace Mirrra
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        void ConfigurationServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DBContent>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
        }



    }
}
