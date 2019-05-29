using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Tapioca.HATEOAS;

namespace Sistema.Data.VO
{
    public class PontosVO : ISupportsHyperMedia
    {
        public Guid? Id { get; set; }
        public Guid UserId { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
