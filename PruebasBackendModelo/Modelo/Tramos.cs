using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendModelo.Modelo
{
    public partial class Tramos
    {
        public int Idref { get; set; }
        public int? Idtramo { get; set; }
        public int? IdtramoOpt { get; set; }
        public string DireccionSalida { get; set; }
        public string DireccionLlegada { get; set; }
        public decimal? DesdeLatitud { get; set; }
        public decimal? DesdeLongitud { get; set; }
        public decimal? HastaLatitud { get; set; }
        public decimal? HastaLongitud { get; set; }
        public int? Metros { get; set; }
        public float? Km { get; set; }
        public int? Segundos { get; set; }
        public string Tiempo { get; set; }
        public int? RetrasoTraficoSegundos { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }

        public virtual TramosId IdrefNavigation { get; set; }
    }
}
