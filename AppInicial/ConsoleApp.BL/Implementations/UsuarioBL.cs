using AppInicial.BL.Contracts;
using AppInicial.CORE.DTO;
using AppInicial.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppInicial.BL.Implementations
{
    public class UsuarioBL : IUsuarioBL
    {
        public IUsuarioRepository _usuarioRepository { get; set; }
        public UsuarioBL(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool Login(UsuarioDTO usuarioDTO)
        {
            return _usuarioRepository.Login(usuarioDTO);
        }
        public IEnumerable<UsuarioDTO> Get()
        {
            var vehiculos = _usuarioRepository.Get();
            return vehiculos;
        }

        public int? GetVentasTotales()
        {
            int? ventasTotales = _usuarioRepository.GetVentasTotales();
            return ventasTotales;
        }
    }
}
