using Microsoft.AspNetCore.Mvc;
using ProductoApp.Models;
using ProductoApp.Services;

namespace ProductoApp.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ProductosController : Controller
    {
        private readonly IAplicacion aplicacion;
        public ProductosController(IAplicacion aplicacion)
        {
            this.aplicacion = aplicacion;
        }

        [HttpGet]
        public IActionResult GetProductos()
        {
            return Ok(aplicacion.GetProductos());
        }
        [HttpPost]
        public IActionResult PostProductos(Producto producto)
        {
            var result = aplicacion.AgregarOEditarProducto(producto);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult Delete(int codigo)
        {
           var result = aplicacion.BorrarProducto(codigo);
            return Ok(result);
        }

    }
}
