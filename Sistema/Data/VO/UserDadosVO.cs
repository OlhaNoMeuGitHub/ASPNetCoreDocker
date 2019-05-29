using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Tapioca.HATEOAS;

namespace Sistema.Data.VO
{
    public class UserDadosVO : ISupportsHyperMedia
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string AccessKey { get; set; }
        public string Cpf { get; set; }
        public string Perfil { get; set; }
        public string Nome { get; set; }
        public double Pontos { get; set; }


        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
