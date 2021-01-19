using AppInicial.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppInicial.DAL.Repositories.Contracts
{
    public interface IVehiculoRepository
    {

        IEnumerable<VehiculoDTO> Get();
        IEnumerable<VehiculoDTO> GetStock();
    }
}
