using System;
using System.Collections.Generic;
using System.Text;

namespace ParquesFinal.Shared.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadPersonas { get; set; }
        public int VisitanteId { get; set; }
        public Visitante Visitante{ get; set; }
        public int ZonaAlojamientoId { get; set; }
        public ZonaAlojamiento ZonaAlojamiento { get; set; }
    }
}
