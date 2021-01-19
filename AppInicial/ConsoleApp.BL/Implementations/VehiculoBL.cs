using AppInicial.BL.Contracts;
using AppInicial.CORE.DTO;
using AppInicial.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppInicial.BL.Implementations
{
    public class VehiculoBL : IVehiculoBL
    {
        public IVehiculoRepository _vehiculoRepository { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="vehiculoRepository"></param>
        public VehiculoBL(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository;
        }

        /// <summary>
        /// Método que nos devuelve la lista de vehículos DTOS
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VehiculoDTO> Get()
        {
            var vehiculos= _vehiculoRepository.Get();
            return vehiculos;
        }


        /// <summary>
        /// Método que nos devuelve la lista de vehículos DTOS
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VehiculoDTO> GetStock()
        {
            var vehiculos = _vehiculoRepository.GetStock();
            return vehiculos;
        }




    }
}
