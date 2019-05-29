using System.Collections.Generic;
using Sistema.Data.Converter;
using Sistema.Model;
using System.Linq;
using Sistema.Data.VO;


namespace Sistema.Data.Converters
{
    public class ProdutosConverter : IParser<ProdutosVO, Produtos>, IParser<Produtos, ProdutosVO>
    {
        public Produtos Parse(ProdutosVO origin)
        {
            if (origin == null) return new Produtos();
            return new Produtos
            {
                Descricao = origin.Descricao,
                Valor = origin.Valor,
                Status = origin.Status
            };
        }

        public ProdutosVO Parse(Produtos origin)
        {
            if (origin == null) return new ProdutosVO();
            return new ProdutosVO
            {
                Id = origin.Id,
                Descricao = origin.Descricao,
                Valor = origin.Valor,
                Status = origin.Status
            };
        }

        public List<Produtos> ParseList(List<ProdutosVO> origin)
        {
            if (origin == null) return new List<Produtos>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ProdutosVO> ParseList(List<Produtos> origin)
        {
            if (origin == null) return new List<ProdutosVO>();
            return origin.Select(item => Parse(item)).ToList();
        }


    }
}
