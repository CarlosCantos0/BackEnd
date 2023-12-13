using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendModelo.Modelo
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public int Idmunicipio { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public DateTime FechaInspeccion { get; set; }
        public int IdtipoInspeccion { get; set; }

        public virtual Municipio IdmunicipioNavigation { get; set; }
        public virtual TipoInspeccion IdtipoInspeccionNavigation { get; set; }
    }
}
