using System;
using System.Collections.Generic;

namespace ParquesFinal.Shared.Entidades
{
    public class ActividadIlicita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoActividadIlicita { get; set; }
        public string Descripcion { get; set; }
        public List<ParqueIlicito> ParqueIlicitos { get; set; } = new List<ParqueIlicito>();
    }

}