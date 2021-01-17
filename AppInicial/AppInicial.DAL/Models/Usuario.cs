using System;
using System.Collections.Generic;

namespace AppInicial.DAL.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Propuesta = new HashSet<Propuesta>();
            Repara = new HashSet<Repara>();
        }

        public int IdUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Pass { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public int? Sueldo { get; set; }
        public string Rol { get; set; }
        public byte? MecanicoJefe { get; set; }
        public byte? EspCoches { get; set; }
        public byte? EspMotos { get; set; }
        public byte? EspCiclomotores { get; set; }
        public int? Ventas { get; set; }
        public int? Concesionario { get; set; }

        public virtual Concesionario ConcesionarioNavigation { get; set; }
        public virtual ICollection<Propuesta> Propuesta { get; set; }
        public virtual ICollection<Repara> Repara { get; set; }
    }
}
