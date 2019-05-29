using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tapioca.HATEOAS;

namespace Sistema.Data.VO
{
    public class PedidosVO : ISupportsHyperMedia
    {

        public Guid? Id { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public Guid UserId { get; set; }
        public Guid ProdutoId { get; set; }
        public Guid EnderecoId { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
