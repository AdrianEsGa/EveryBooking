using EveryBooking.Api.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EveryBooking.Api
{
    public class BloggingContextFactory : Microsoft.EntityFrameworkCore.Design.IDesignTimeDbContextFactory<EveryBookingDbContext>
    {
        public IConfiguration Configuration { get; }

        public EveryBookingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EveryBookingDbContext>();
            optionsBuilder.UseSqlServer("Server=ADRIANPC\\SQLEXPRESS;Database=EveryBooking;User Id=sa;Password=1234;MultipleActiveResultSets=False");

            return new EveryBookingDbContext(optionsBuilder.Options);
        }
    }

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<EveryBookingDbContext>(options
                   => options.UseSqlServer(Configuration.GetConnectionString("DataBaseConnection"), 
                   providerOptions => providerOptions.EnableRetryOnFailure()));

            services.AddControllers();        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
