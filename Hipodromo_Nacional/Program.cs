using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Hipodromo.BL;

var builder = WebApplication.CreateBuilder(args);

// ==========================================
// 1. SERVICIOS
// ==========================================

builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();

var connectionString = builder.Configuration.GetConnectionString("SupabaseConnection");
builder.Services.AddDbContext<PostgresContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<CaballoService>();
builder.Services.AddScoped<EstabloService>();
builder.Services.AddScoped<CarreraService>();
builder.Services.AddScoped<PropietarioService>();
builder.Services.AddScoped<SuministroService>();
builder.Services.AddScoped<AlimentacionService>();
builder.Services.AddScoped<FacturacionService>();

// ==========================================
// 2. CONSTRUCCIÓN DE LA APLICACIÓN
// ==========================================

var app = builder.Build();

// ==========================================
// 3. PIPELINE
// ==========================================

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
