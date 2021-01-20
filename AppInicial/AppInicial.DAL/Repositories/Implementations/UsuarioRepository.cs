using AppInicial.CORE.DTO;
using AppInicial.DAL.Models;
using AppInicial.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppInicial.DAL.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public bd_tallerContext _context { get; set; }

        public UsuarioRepository(bd_tallerContext context)
        {
            _context = context;
        }
        public bool Login(UsuarioDTO usuarioDTO)
        {
            return _context.Usuario.Any(u => u.Usuario1 == usuarioDTO.UserName &&
                         u.Pass == usuarioDTO.Password && u.Rol =="Jefe");
        }

        public IEnumerable<UsuarioDTO> Get()
        {
            var usuarios = _context.Usuario.ToList();

            //Mapeo de Usuario a UsuarioDTO
            List<UsuarioDTO> usuariosdto = new List<UsuarioDTO>();

            foreach (var u in usuarios)
            {
                var usuario = new UsuarioDTO
                {
                    IdUsuario = u.IdUsuario,
                    UserName = u.Usuario1,
                    Password = u.Pass,
                    Nombre = u.Nombre,
                    Apellidos = u.Apellidos,
                    Telefono = u.Telefono,
                    Sueldo = u.Sueldo,
                    Rol = u.Rol,
                    MecanicoJefe = u.MecanicoJefe,
                    EspCoches = u.EspCoches,
                    EspMotos = u.EspMotos,
                    EspCiclo = u.EspCiclomotores,
                    Ventas = u.Ventas,
                    Concesionario = u.Concesionario,
                };
                if (usuario.Rol.Equals("Ventas"))
                {
                    usuariosdto.Add(usuario);

                }
            }

            return usuariosdto;

        }

        public int? GetVentasTotales()
        {
            var usuarios = _context.Usuario.ToList();
            int? ventasTotales = 0;
            //Mapeo de Usuario a UsuarioDTO
            List<UsuarioDTO> usuariosdto = new List<UsuarioDTO>();

            foreach (var u in usuarios)
            {
                var usuario = new UsuarioDTO
                {
                    IdUsuario = u.IdUsuario,
                    UserName = u.Usuario1,
                    Password = u.Pass,
                    Nombre = u.Nombre,
                    Apellidos = u.Apellidos,
                    Telefono = u.Telefono,
                    Sueldo = u.Sueldo,
                    Rol = u.Rol,
                    MecanicoJefe = u.MecanicoJefe,
                    EspCoches = u.EspCoches,
                    EspMotos = u.EspMotos,
                    EspCiclo = u.EspCiclomotores,
                    Ventas = u.Ventas,
                    Concesionario = u.Concesionario,
                };
                if (usuario.Rol.Equals("Ventas"))
                {

                    ventasTotales += usuario.Ventas;
                }
            }

            return ventasTotales;

        }


    }
}
