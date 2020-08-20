using Microsoft.AspNetCore.Mvc;
using ServicesInventario.Models;
using ServicesInventario.Repository;
namespace ServicesInventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPInventario rpInv = new RPInventario();
            return Ok(rpInv.ObtenerProducto());
        }

        [HttpPost("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            RPInventario rpInv = new RPInventario();
            rpInv.EliminarProducto(id);
            return CreatedAtAction(nameof(EliminarProducto), id);

        }

        [HttpDelete("agregar")]
        public IActionResult AgregarProducto(InventarioViewModels nuevoProducto)
        {
            RPInventario rpInv = new RPInventario();
            rpInv.AgregarProducto(nuevoProducto);
            return CreatedAtAction(nameof(AgregarProducto), nuevoProducto);
        }
    }
}
