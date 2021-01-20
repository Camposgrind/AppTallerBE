using AppInicial.BL.Contracts;
using AppInicial.CORE.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppInicial.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        public IUsuarioBL _usuarioBL { get; set; }

        public UsuarioController(IUsuarioBL usuarioBL)
        {
            _usuarioBL = usuarioBL;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UsuarioDTO>> Get()
        {
            return Ok(_usuarioBL.Get());
        }

        [HttpGet]
        [Route("ventasTotales")]
        public ActionResult <int?> GetVentasTotales()
        {
            return Ok(_usuarioBL.GetVentasTotales());
        }

    }
}
