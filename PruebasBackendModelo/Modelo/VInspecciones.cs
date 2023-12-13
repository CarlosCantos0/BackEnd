using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendModelo.Modelo
{
    public partial class VInspecciones
    {
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public int CodigoMunicipio { get; set; }
        public string Municipio { get; set; }
        public DateTime FechaInspeccion { get; set; }
        public string CodigoTipoInspeccion { get; set; }
        public string TipoInspeccion { get; set; }
        public int Idcliente { get; set; }
        public int Idmunicipio { get; set; }
        public int IdtipoInspeccion { get; set; }
    }
}
