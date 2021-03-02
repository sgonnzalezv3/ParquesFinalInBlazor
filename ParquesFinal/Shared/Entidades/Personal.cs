namespace ParquesFinal.Shared.Entidades
{
    public class Personal : Usuario
    {
        public string Img { get; set; }
        public int IdParque { get; set; }
        public Parque Parque { get; set; }

    }
}