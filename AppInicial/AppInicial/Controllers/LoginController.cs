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
    public class LoginController : ControllerBase
    {
        public IUsuarioBL _usuarioBL{ get; set; }

        public LoginController(IUsuarioBL usuarioBL)
        {
            _usuarioBL = usuarioBL;
        }
        [HttpPost]
        public bool Login(UsuarioDTO usuarioDTO)
        {
           return _usuarioBL.Login(usuarioDTO);
        }


    }

}
