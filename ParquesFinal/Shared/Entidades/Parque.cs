using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParquesFinal.Shared.Entidades
{
    public class Parque
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]

        public string Nombre { get; set; }
        public string Extension { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime? FechaCreacion { get; set; }
        public string Region { get; set; }
        public bool Estado  { get; set; }

        public Administrador Administrador { get; set; }
        public List<Personal> Personales { get; set; }
        public List<ParqueIlicito> ParqueIlicitos { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        public List<ZonaAlojamiento> ZonasDeAlojamiento { get; set; }
        public List<ParqueEcosistema> ParqueEcosistemas { get; set; } = new List<ParqueEcosistema>();
   
        public string Img { get; set; }

    }
}
