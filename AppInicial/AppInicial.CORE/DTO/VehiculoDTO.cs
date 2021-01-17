using System;
using System.Collections.Generic;
using System.Text;

namespace AppInicial.CORE.DTO
{
    public class VehiculoDTO
    {

        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public int? Precio { get; set; }
        public int? Kilometros { get; set; }
        public string Color { get; set; }
        public string Combustible { get; set; }
        public string FechaEntrada { get; set; }
        public int? IdConcesionario { get; set; }
        public int? IdCliente { get; set; }
        public byte? Vendido { get; set; }

        public VehiculoDTO()
        {

        }
    }
}
