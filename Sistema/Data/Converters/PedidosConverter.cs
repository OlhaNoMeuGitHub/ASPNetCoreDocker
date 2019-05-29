using System.Collections.Generic;
using Sistema.Data.Converter;
using Sistema.Model;
using System.Linq;
using Sistema.Data.VO;


namespace Sistema.Data.Converters
{
    public class PedidosConverter : IParser<PedidosVO, Pedidos>, IParser<Pedidos, PedidosVO>
    {

        public Pedidos Parse(PedidosVO origin)
        {
            if (origin == null) return new Pedidos();
            return new Pedidos
            {
                Valor = origin.Valor,
                Descricao = origin.Descricao,
                Data = origin.Data,
                UserId = origin.UserId,
                EnderecoId = origin.EnderecoId,
                ProdutoId = origin.ProdutoId,
                Status = origin.Status
            };
        }

        public PedidosVO Parse(Pedidos origin)
        {
            if (origin == null) return new PedidosVO();
            return new PedidosVO
            {
                Valor = origin.Valor,
                Descricao = origin.Descricao,
                Data = origin.Data,
                UserId = origin.UserId,
                EnderecoId = origin.EnderecoId,
                ProdutoId = origin.ProdutoId,
                Status = origin.Status
            };
        }

        public List<Pedidos> ParseList(List<PedidosVO> origin)
        {
            if (origin == null) return new List<Pedidos>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PedidosVO> ParseList(List<Pedidos> origin)
        {
            if (origin == null) return new List<PedidosVO>();
            return origin.Select(item => Parse(item)).ToList();
        }


    }
}
