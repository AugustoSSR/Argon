using Argon.Data;
using Argon.Helper;
using Argon.Repositorio;
using Argon.Repositorio.?nterface;
using Microsoft.EntityFrameworkCore;


namespace Argon
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"));
            });
            //builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //builder.Services.AddScoped<IProjetosRepositorio, ProjetosRepositorio>();
            //builder.Services.AddScoped<IUsuariosRepositorio, UsuariosRepositorio>();
            //builder.Services.AddScoped<IEmpresasRepositorio, EmpresasRepositorio>();
            //builder.Services.AddScoped<IArquivoRepositorio, ArquivoRepositorio>();
            //builder.Services.AddScoped<IEngenheirosRepositorio, EngenheirosRepositorio>();
            //builder.Services.AddScoped<ISessao, Sessao>();
            //builder.Services.AddScoped<IEmail, Email>();
            //builder.Services.AddSession(o =>
            //{
            //    o.Cookie.HttpOnly = true;
            //    o.Cookie.IsEssential = true;
            //});
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
