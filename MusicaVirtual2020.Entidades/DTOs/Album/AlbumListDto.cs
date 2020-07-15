using MusicaVirtual2020.Entidades.DTOs.Interprete;

namespace MusicaVirtual2020.Entidades.DTOs.Album
{
    public class AlbumListDto
    {
        public int AlbumId { get; set; }
        public string Titulo { get; set; }
        public string Interprete { get; set; }
        public int Pistas { get; set; }
    }
}
