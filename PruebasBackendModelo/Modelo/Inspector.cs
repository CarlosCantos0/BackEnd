using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendModelo.Modelo
{
    public partial class Inspector
    {
        public Inspector()
        {
            InspectorDisponible = new HashSet<InspectorDisponible>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Idmunicipio { get; set; }
        public int IdtipoInspeccion { get; set; }

        public virtual Municipio IdmunicipioNavigation { get; set; }
        public virtual TipoInspeccion IdtipoInspeccionNavigation { get; set; }
        public virtual ICollection<InspectorDisponible> InspectorDisponible { get; set; }
    }
}
