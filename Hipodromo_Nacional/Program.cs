using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ==========================================
// 1. CONFIGURACIÓN DE SERVICIOS (DI CONTAINER)
// ==========================================

builder.Services.AddControllers();

// Configuración de la conexión a Supabase con PostgreSQL
var connectionString = builder.Configuration.GetConnectionString("SupabaseConnection");
builder.Services.AddDbContext<Hipodromo_Nacional.Models.PostgresContext>(options =>
    options.UseNpgsql(connectionString));

// Configuración de OpenAPI (Swagger / Documentación)
builder.Services.AddOpenApi();


// ==========================================
// 2. CONSTRUCCIÓN DE LA APLICACIÓN
// ==========================================

var app = builder.Build();


// ==========================================
// 3. CONFIGURACIÓN DEL PIPELINE DE PETICIONES (MIDDLEWARE)
// ==========================================

// Configurar el pipeline para el entorno de desarrollo
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// ==========================================
// 4. EJECUCIÓN DE LA APLICACIÓN
// ==========================================

app.Run();
