using AppInicial.CORE.DTO;
using AppInicial.DAL.Models;
using AppInicial.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppInicial.DAL.Repositories.Implementations
{
    public class VehiculoRepository : IVehiculoRepository
    {
        public bd_tallerContext _context { get; set; }

        public VehiculoRepository(bd_tallerContext context)
        {
            _context = context;
        }

        public IEnumerable<VehiculoDTO> Get()
        {
            var vehiculos = _context.Vehiculo.ToList();

            //Mapeo de Vehiculo a VehiculoDTO
            List<VehiculoDTO> vehiculosdto= new List<VehiculoDTO>();

            foreach (var v in vehiculos)
            {
                var vehiculo = new VehiculoDTO
                {
                    Matricula = v.Matricula,
                    Marca = v.Marca,
                    Modelo = v.Modelo,
                    Tipo = v.Tipo,
                    Precio = v.Precio,
                    Kilometros = v.Kilometros,
                    Color = v.Color,
                    Combustible = v.Combustible,
                    FechaEntrada = v.FechaEntrada.ToString(),
                    IdConcesionario = v.IdConcesionario,
                    IdCliente = v.IdCliente,
                    Vendido = v.Vendido,
                };
                if (vehiculo.Vendido==1 &&vehiculo.Precio!=null && vehiculo.Precio!=0)
                {
                    vehiculosdto.Add(vehiculo);

                }
            }

            return vehiculosdto;

        }


        public IEnumerable<VehiculoDTO> GetStock()
        {
            var vehiculos = _context.Vehiculo.ToList();

            //Mapeo de Vehiculo a VehiculoDTO
            List<VehiculoDTO> vehiculosdto = new List<VehiculoDTO>();

            foreach (var v in vehiculos)
            {
                var vehiculo = new VehiculoDTO
                {
                    Matricula = v.Matricula,
                    Marca = v.Marca,
                    Modelo = v.Modelo,
                    Tipo = v.Tipo,
                    Precio = v.Precio,
                    Kilometros = v.Kilometros,
                    Color = v.Color,
                    Combustible = v.Combustible,
                    FechaEntrada = v.FechaEntrada.ToString(),
                    IdConcesionario = v.IdConcesionario,
                    IdCliente = v.IdCliente,
                    Vendido = v.Vendido,
                };
                if (vehiculo.Vendido == 0)
                {
                    vehiculosdto.Add(vehiculo);

                }
            }

            return vehiculosdto;

        }


    }
}
