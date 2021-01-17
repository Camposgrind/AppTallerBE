using System;
using System.Collections.Generic;

namespace AppInicial.DAL.Models
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Propuesta = new HashSet<Propuesta>();
            Repara = new HashSet<Repara>();
        }


        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public int? Precio { get; set; }
        public int? Kilometros { get; set; }
        public string Color { get; set; }
        public string Combustible { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public int? IdConcesionario { get; set; }
        public int? IdCliente { get; set; }
        public byte? Vendido { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Concesionario IdConcesionarioNavigation { get; set; }
        public virtual ICollection<Propuesta> Propuesta { get; set; }
        public virtual ICollection<Repara> Repara { get; set; }
    }
}
