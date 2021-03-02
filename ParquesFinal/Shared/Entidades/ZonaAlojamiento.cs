using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParquesFinal.Shared.Entidades
{
    public class ZonaAlojamiento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int Costo { get; set; }
        public int Capacidad { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int ParqueId { get; set; }
        public Parque Parque { get; set; }
        public List<Reserva> Reservas { get; set; }

    }
}
