using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hipodromo_Nacional.Hipodromo.DA;
using Hipodromo_Nacional.Models;

namespace Hipodromo_Nacional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        private readonly PostgresContext _context;

        // Inyectamos el contexto que configuramos en el Program.cs
        public PruebaController(PostgresContext context)
        {
            _context = context;
        }

        [HttpGet("conexion")]
        public async Task<IActionResult> TestConexion()
        {
            try
            {
                // 1. Intentamos hacer una consulta simple de conteo a la tabla Usuarios
                // Nota: Si tu tabla Usuarios no tiene registros o prefieres usar otra, 
                // puedes cambiar 'Usuarios' por cualquier otra tabla como 'Pais' o 'Establos'.
                var totalUsuarios = await _context.Usuarios.CountAsync();

                // 2. Si todo sale bien, respondemos un mensaje de éxito
                return Ok(new
                {
                    status = "Éxito",
                    mensaje = "¡Conexión establecida perfectamente con Supabase!",
                    total_registros_usuarios = totalUsuarios,
                    fecha_verificacion = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                // 3. Si hay algún error de red, credenciales o nombres, saltará aquí
                return StatusCode(500, new
                {
                    status = "Error",
                    mensaje = "Hubo un problema al conectar con la base de datos.",
                    detalles_error = ex.InnerException?.Message ?? ex.Message
                });
            }
        }
    }
}
