using Argon.Data;
using Argon.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace Argon
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // conexão com banco de dados.
            // dependencia sqlserver.
            // puxar dados do appsettings.json
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<DBContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DataBase")));
            services.AddScoped<IProjetosRepositorio, ProjetosRepositorio>();
            services.AddScoped<IUsuariosRepositorio, UsuariosRepositorio>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
