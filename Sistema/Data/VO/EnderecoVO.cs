using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Tapioca.HATEOAS;

namespace Sistema.Data.VO
{
    public class EnderecoVO : ISupportsHyperMedia
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public Guid UserId { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
