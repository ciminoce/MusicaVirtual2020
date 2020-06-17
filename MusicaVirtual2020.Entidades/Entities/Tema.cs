namespace MusicaVirtual2020.Entidades.Entities
{
    public class Tema
    {
        public int TemaId { get; set; }
        public int PistaNro { get; set; }
        public string Nombre { get; set; }
        public float Duracion { get; set; }
        public Album Album { get; set; }
    }
}
