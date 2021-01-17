using System;
using System.Collections.Generic;
using System.Text;

namespace AppInicial.CORE.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public int? Sueldo { get; set; }
        public string Rol { get; set; }
        public byte? MecanicoJefe { get; set; }
        public byte? EspCoches { get; set; }
        public byte? EspMotos { get; set; }
        public byte? EspCiclo { get; set; }
        public int? Ventas { get; set; }
        public int? Concesionario { get; set; }

        public UsuarioDTO()
        {

        }
    }

}
