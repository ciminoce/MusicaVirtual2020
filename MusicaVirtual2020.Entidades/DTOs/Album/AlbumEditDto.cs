using System;
using System.Collections.Generic;
using MusicaVirtual2020.Entidades.DTOs.Estilo;
using MusicaVirtual2020.Entidades.DTOs.Interprete;
using MusicaVirtual2020.Entidades.DTOs.Negocio;
using MusicaVirtual2020.Entidades.DTOs.Soporte;
using MusicaVirtual2020.Entidades.DTOs.Tema;

namespace MusicaVirtual2020.Entidades.DTOs.Album
{
    public class AlbumEditDto
    {
        public int AlbumId { get; set; }
        public string Titulo { get; set; }
        public InterpreteListDto InterpreteListDto { get; set; }
        public EstiloListDto EstiloListDto { get; set; }
        public SoporteListDto SoporteListDto { get; set; }
        public Int16 Pistas { get; set; }
        public NegocioListDto NegocioListDto { get; set; }
        public int AnioCompra { get; set; }
        public decimal Costo { get; set; }
        public List<TemaListDto> TemasDto { get; set; } = new List<TemaListDto>();

    }
}
