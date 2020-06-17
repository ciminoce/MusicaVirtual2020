using System;

namespace MusicaVirtual2020.Entidades.Entities
{
    public class Negocio:ICloneable
    {
        public int NegocioId { get; set; }
        public string Nombre { get; set; }
        public Pais Pais { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
