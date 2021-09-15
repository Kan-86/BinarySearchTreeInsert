using BinaryTree.CoreProject.BinaryTree.Core.ApplicationServices;
using BinaryTree.CoreProject.BinaryTree.Core.ApplicationServices.BinaryTree.Core.Services;
using BinaryTree.CoreProject.DomainServices;
using InfastructureProject;
using InfastructureProject.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BinaryTreeWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BinarySearchTreeContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("BSTDb")));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BinaryTreeWebAPI", Version = "v1" });
            });
            services.AddScoped<IBSTServices, BSTServices> ();
            services.AddScoped<IBSTRepository, BSTRepository> ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BinaryTreeWebAPI v1"));
                using (var scope = app.ApplicationServices.CreateScope())
                {

                    var ctx = scope.ServiceProvider.GetService<BinarySearchTreeContext>();
                    ctx.Database.EnsureCreated();
                    //DbInitializer.SeedDb(ctx);
                }
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
