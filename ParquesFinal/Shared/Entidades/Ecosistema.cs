using System.Collections.Generic;

namespace ParquesFinal.Shared.Entidades
{
    public class Ecosistema
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCientifico  { get; set; }
        public string Descripcion  { get; set; }
        public List<ParqueEcosistema> ParqueEcosistemas { get; set; }  = new List<ParqueEcosistema>();
    }
}