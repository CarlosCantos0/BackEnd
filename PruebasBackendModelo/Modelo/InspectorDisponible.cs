using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendModelo.Modelo
{
    public partial class InspectorDisponible
    {
        public int Id { get; set; }
        public int Idinspector { get; set; }
        public DateTime Fecha { get; set; }
        public bool Disponible { get; set; }

        public virtual Inspector IdinspectorNavigation { get; set; }
    }
}
