using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParquesFinal.Shared.Entidades
{
    public class Car
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public DateTime? FCreacion { get; set; }
        public List<Parque> Parques { get; set; }

    }
}
