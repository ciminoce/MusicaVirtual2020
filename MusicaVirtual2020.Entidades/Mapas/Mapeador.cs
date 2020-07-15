using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Entidades.Mapas
{
    public class Mapeador
    {
        public static AlbumListDto ConvertirDesdeAlbum(Album album)
        {
            return new AlbumListDto
            {
                AlbumId = album.AlbumId,
                Titulo = album.Titulo,
                Interprete = album.Interprete.Nombre,
                Pistas = album.Pistas,
            };
        }
    }
}
