using Microsoft.AspNetCore.Mvc;
using NoticiasAPI.Models;
using NoticiasAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
   public class NoticiaController : Controller
    {
        private readonly NoticiaServices _noticiaServices;


      public  NoticiaController(NoticiaServices noticiaServices)
        {
           _noticiaServices = noticiaServices;

        }
        [HttpGet]
        [Route("obtener")]
        public IActionResult Obtener()
        {
            var resultado = _noticiaServices.Obtener();
            return Ok(resultado);
        }
        [HttpPost]
        [Route("agregar")]
        public IActionResult Agregar([FromBody] Noticia _noticia)
        {
            var resultado = _noticiaServices.AgregarNoticia(_noticia);
            if (resultado) { 
            return Ok();
            }
            else
            {
             return BadRequest();
            }
        }
        [HttpPut]
        [Route("editar")]
        public IActionResult Editar([FromBody] Noticia _noticia)
        {
            var resultado = _noticiaServices.EditarNoticia(_noticia);
            if (resultado)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("eliminar/{NoticiaID}")]
        public IActionResult Eliminar(int NoticiaID)
        {
            var resultado = _noticiaServices.EliminarNoticia(NoticiaID);
            if (resultado)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
