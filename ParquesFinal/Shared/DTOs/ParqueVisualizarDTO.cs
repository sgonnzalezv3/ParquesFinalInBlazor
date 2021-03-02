using ParquesFinal.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParquesFinal.Shared.DTOs
{
    public class ParqueVisualizarDTO
    {
        public int ParqueId { get; set; }
        public List<Car> Cars { get; set; }
        public List<Personal> Personales { get; set; }
        public List<Ecosistema> Ecosistemas { get; set; }
        public List<ZonaAlojamiento> ZonasAlojamiento { get; set; }
        public Administrador Administrador { get; set; }
        public List<ActividadIlicita> ActividadesIlicitas { get; set; }
    }
}
