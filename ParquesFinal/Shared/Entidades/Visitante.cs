using System;
using System.Collections.Generic;
using System.Text;

namespace ParquesFinal.Shared.Entidades
{
    public class Visitante
    {
        public int Id { get; set; }
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public DateTime FNacimiento {get; set;}
        public string  Genero { get; set; }
        public List<Reserva> Reservas { get; set; }
    }
}
