using CarpinteriaBack.Entidades;
using CarpinteriaBack.Fachada.Implementacion;
using CarpinteriaBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarpinteriaWebApi
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestoController : ControllerBase
    {
        private IAplicacion app;
        public PresupuestoController()
        {
            app = new Aplicacion();
        }

        // GET: api/<PresupuestoController>
        [HttpGet("/productos")]
        public IActionResult GetPresupuestos()
        {
            List<Producto>? list = null;

            try
            {
                list = app.GetProductos();
                return Ok(list);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error Interno!! Intente luego");
            }
            
        }

        // POST api/<PresupuestoController>
        [HttpPost]
        public IActionResult PostPresupuesto(Presupuesto oPresupuesto)
        {
            try
            {
                if (oPresupuesto == null)
                {
                    return BadRequest("No se pueden cargar presupuestos nulos!!");
                }
                if (app.SavePresupuesto(oPresupuesto))
                {
                    return Ok(oPresupuesto);
                }
                else
                {
                    return NotFound("No se pudo guardar el presupuesto!!!");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error Interno!! Intente luego");
            }
        }

        //// PUT api/<PresupuestoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PresupuestoController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
