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
    public class VehiculoController : ControllerBase
    {
        public IVehiculoBL _vehiculoBL { get; set; }
        
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="iVehiculoBL"></param>
        public VehiculoController(IVehiculoBL iVehiculoBL)
        {
            _vehiculoBL = iVehiculoBL;

        }
        /// <summary>
        /// Método que nos devuelve un lista de vehículosDTO
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<VehiculoDTO>> Get()
        {
            return Ok(_vehiculoBL.Get());
        }

        [HttpGet]
        [Route("stock")]
        public ActionResult<IEnumerable<VehiculoDTO>> GetStock()
        {
            return Ok(_vehiculoBL.GetStock());
        }


    }
}
