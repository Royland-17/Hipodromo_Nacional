using Hipodromo_Nacional.Models;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.LogicaDeNegocios.Services;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .ConfigureApplicationPartManager(manager =>
    {
        var referencedWebPart = manager.ApplicationParts
            .OfType<AssemblyPart>()
            .FirstOrDefault(part => string.Equals(part.Name, "Hipodromo_Nacional", StringComparison.Ordinal));

        if (referencedWebPart is not null)
        {
            manager.ApplicationParts.Remove(referencedWebPart);
        }
    });
builder.Services.AddMemoryCache();
builder.Services.AddScoped<IPropietariosServicios, PropietariosServicios>();

var connectionString = builder.Configuration.GetConnectionString("SupabaseConnection")
    ?? throw new InvalidOperationException("Connection string 'SupabaseConnection' was not found.");

var csb = new NpgsqlConnectionStringBuilder(connectionString)
{
    Timeout = 15,
    CommandTimeout = 180,
    KeepAlive = 30,
    Pooling = true,
    MaxPoolSize = 30
};

builder.Services.AddDbContext<PostgresContext>(options =>
    options.UseNpgsql(csb.ConnectionString, npgsqlOptions =>
    {
        npgsqlOptions.CommandTimeout(180);
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
