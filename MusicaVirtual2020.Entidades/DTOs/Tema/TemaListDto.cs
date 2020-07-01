using System.Security.AccessControl;

namespace MusicaVirtual2020.Entidades.DTOs.Tema
{
    public class TemaListDto
    {
        public int TemaId { get; set; }
        public int NroTema { get; set; }
        public string Nombre { get; set; }
        public float Duracion { get; set; }
    }
}
