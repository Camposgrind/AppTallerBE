using System;
using System.Collections.Generic;

namespace AppInicial.DAL.Models
{
    public partial class Propuesta
    {
        public int IdPropuesta { get; set; }
        public int Usuario { get; set; }
        public int Cliente { get; set; }
        public string VehMatricula { get; set; }
        public DateTime Fecha { get; set; }
        public int Presupuesto { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
        public virtual Usuario UsuarioNavigation { get; set; }
        public virtual Vehiculo VehMatriculaNavigation { get; set; }
    }
}
