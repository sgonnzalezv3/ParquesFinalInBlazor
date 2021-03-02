using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParquesFinal.Shared.DTOs
{
   public  class UserInfo
    {
        [Required(ErrorMessage ="El Email es requerido")  ]
        public string Email { get; set; }
        [Required (ErrorMessage ="Contraseña Requerida")]
        public string Password { get; set; }
    }
}
