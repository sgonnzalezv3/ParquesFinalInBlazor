using System;
using System.Collections.Generic;
using System.Text;

namespace ParquesFinal.Shared.Entidades
{
   public  class ParqueIlicito
    {
        public int ParqueId { get; set; }
        public int ActividadIlicitaId { get; set; }
        public Parque Parque { get; set; }
        public ActividadIlicita ActividadIlicita {get;set;}
    }
}
