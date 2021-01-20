using AppInicial.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppInicial.DAL.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        bool Login(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();
        public int? GetVentasTotales();
    }
}
