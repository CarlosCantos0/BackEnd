using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendModelo.Modelo
{
    public partial class TipoInspeccion
    {
        public TipoInspeccion()
        {
            Cliente = new HashSet<Cliente>();
            Inspector = new HashSet<Inspector>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan? Tiempo { get; set; }
        public int? Segundos { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Inspector> Inspector { get; set; }
    }
}
