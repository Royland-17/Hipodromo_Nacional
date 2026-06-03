using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Hipodromo.BL;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// ==========================================
// 1. SERVICIOS
// ==========================================

builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();
builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/Login";
        options.AccessDeniedPath = "/Auth/AccessDenied";
        options.SlidingExpiration = true;
        options.ExpireTimeSpan = TimeSpan.FromHours(8);
    });
builder.Services.AddAuthorization();

var connectionString = builder.Configuration.GetConnectionString("LocalPostgresConnection")
    ?? builder.Configuration.GetConnectionString("SupabaseConnection");

if (string.IsNullOrWhiteSpace(connectionString))
    throw new InvalidOperationException("No se encontro cadena de conexion configurada.");

builder.Services.AddDbContext<PostgresContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<CaballoService>();
builder.Services.AddScoped<EstabloService>();
builder.Services.AddScoped<CarreraService>();
builder.Services.AddScoped<PropietarioService>();
builder.Services.AddScoped<SuministroService>();
builder.Services.AddScoped<AlimentacionService>();
builder.Services.AddScoped<FacturacionService>();
builder.Services.AddScoped<InscripcionesEventoService>();
builder.Services.AddScoped<ResultadosService>();
builder.Services.AddScoped<AuthService>();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}");

app.Run();
