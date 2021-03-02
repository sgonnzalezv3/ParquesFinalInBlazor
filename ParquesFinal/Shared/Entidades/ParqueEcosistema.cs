using System;
using System.Collections.Generic;
using System.Text;

namespace ParquesFinal.Shared.Entidades
{
    public class ParqueEcosistema
    {
        public int ParqueId { get; set; }
        public int EcosistemaId { get; set; }

        public Parque Parque { get; set; }
        public Ecosistema Ecosistema { get; set; }
    }
}
