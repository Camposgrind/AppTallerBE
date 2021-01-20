using AppInicial.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppInicial.BL.Contracts
{
    public interface IUsuarioBL
    {
        bool Login(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();

        public int? GetVentasTotales();
    }
}
