using System;
using System.Collections.Generic;

namespace AppInicial.DAL.Models
{
    public partial class Repara
    {
        public int IdRepara { get; set; }
        public int? IdUsuario { get; set; }
        public string Matricula { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public int? Presupuesto { get; set; }
        public string Piezas { get; set; }
        public string Tiempo { get; set; }
        public string Tarea { get; set; }
        public string Estado { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual Vehiculo MatriculaNavigation { get; set; }
    }
}
