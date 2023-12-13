using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendModelo.Modelo
{
    public partial class MatrixGoogle
    {
        public int Id { get; set; }
        public int? Idorigen { get; set; }
        public decimal? LatOrigen { get; set; }
        public decimal? LngOrigen { get; set; }
        public int? Iddestino { get; set; }
        public decimal? LatDestino { get; set; }
        public decimal? LngDestino { get; set; }
        public int? Segundos { get; set; }
        public int? Metros { get; set; }
    }
}
