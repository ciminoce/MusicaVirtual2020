using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.DTOs.Estilo;
using MusicaVirtual2020.Entidades.DTOs.Interprete;
using MusicaVirtual2020.Entidades.DTOs.Negocio;
using MusicaVirtual2020.Entidades.DTOs.Soporte;
using MusicaVirtual2020.Entidades.DTOs.Tema;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Entidades.Mapas
{
    public class Mapeador
    {
        public static InterpreteListDto ConvertirInterpreteListDto(Interprete interprete)
        {
            return new InterpreteListDto
            {
                InterpreteId = interprete.InterpreteId,
                Nombre = interprete.Nombre
            };
        }
        public static Estilo ConvertirEstilo(EstiloListDto estiloListDto)
        {
            return new Estilo
            {
                EstiloId = estiloListDto.EstiloId,
                Nombre = estiloListDto.Nombre
            };
        }

        public static EstiloListDto ConvertirEstiloDto(Estilo estilo)
        {
            return new EstiloListDto
            {
                EstiloId = estilo.EstiloId,
                Nombre = estilo.Nombre
            };
        }

        public static SoporteListDto ConvertirSoporteDto(Soporte soporte)
        {
            return new SoporteListDto
            {
                SoporteId = soporte.SoporteId,
                Descripcion = soporte.Descripcion
            };
        }

        public static NegocioListDto ConvertirNegocioDto(Negocio negocio)
        {
            return new NegocioListDto
            {
                NegocioId = negocio.NegocioId,
                Nombre = negocio.Nombre
            };
        }

        public static Album ConvertirAlbum(AlbumEditDto albumEditDto)
        {
            Album album=new Album
            {
                AlbumId = albumEditDto.AlbumId,
                Titulo = albumEditDto.Titulo,
                Pistas = albumEditDto.Pistas,
                Costo = albumEditDto.Costo,
                AnioCompra = albumEditDto.AnioCompra,
                Interprete = ConvertirInterprete(albumEditDto.InterpreteListDto),
                Estilo = ConvertirEstilo(albumEditDto.EstiloListDto),
                Soporte = ConvertirSoporte(albumEditDto.SoporteListDto),
                Negocio = ConvertirNegocio(albumEditDto.NegocioListDto)

            };
            if (albumEditDto.TemasDto.Count>0)
            {
                albumEditDto.TemasDto.ForEach(t =>
                {
                    Tema tema = ConvertirTema(t);
                    album.Temas.Add(tema);
                });
            }

            return album;
        }

        public static Negocio ConvertirNegocio(NegocioListDto negocioListDto)
        {
            return new Negocio
            {
                NegocioId = negocioListDto.NegocioId,
                Nombre = negocioListDto.Nombre
            };
        }

        public static Soporte ConvertirSoporte(SoporteListDto soporteListDto)
        {
            return new Soporte
            {
                SoporteId = soporteListDto.SoporteId,
                Descripcion = soporteListDto.Descripcion
            };
        }


        public static Interprete ConvertirInterprete(InterpreteListDto interpreteListDto)
        {
            return new Interprete
            {
                InterpreteId = interpreteListDto.InterpreteId,
                Nombre = interpreteListDto.Nombre
            };
        }

        public static AlbumListDto ConvertirAlbumDto(AlbumEditDto albumEditDto)
        {
            return new AlbumListDto
            {
                AlbumId = albumEditDto.AlbumId,
                Titulo = albumEditDto.Titulo,
                Pistas = albumEditDto.Pistas,
                InterpreteListDto = albumEditDto.InterpreteListDto
            };
        }

        public static Tema ConvertirTema(TemaListDto temaDto)
        {
            return new Tema
            {
                TemaId = temaDto.TemaId,
                PistaNro = temaDto.NroTema,
                Nombre = temaDto.Nombre,
                Duracion = temaDto.Duracion
            };
        }
    }
}
