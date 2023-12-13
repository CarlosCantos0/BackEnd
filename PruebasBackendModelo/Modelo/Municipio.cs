using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendModelo.Modelo
{
    public partial class Municipio
    {
        public Municipio()
        {
            Cliente = new HashSet<Cliente>();
            Inspector = new HashSet<Inspector>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get; set; }
        public int Habitantes { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Inspector> Inspector { get; set; }
    }
}
