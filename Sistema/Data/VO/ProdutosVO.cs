using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Tapioca.HATEOAS;


namespace Sistema.Data.VO
{
    public class ProdutosVO : ISupportsHyperMedia
    {
        public Guid? Id { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
