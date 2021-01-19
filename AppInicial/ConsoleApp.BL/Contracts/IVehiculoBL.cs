using AppInicial.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppInicial.BL.Contracts
{
    public interface IVehiculoBL
    {
        IEnumerable<VehiculoDTO> Get();
        IEnumerable<VehiculoDTO> GetStock();

    }
}
