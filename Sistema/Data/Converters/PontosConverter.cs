using System.Collections.Generic;
using Sistema.Data.Converter;
using Sistema.Model;
using System.Linq;
using Sistema.Data.VO;


namespace Sistema.Data.Converters
{
    public class PontosConverter : IParser<PontosVO, Pontos>, IParser<Pontos, PontosVO>
    {

        public Pontos Parse(PontosVO origin)
        {
            if (origin == null) return new Pontos();
            return new Pontos
            {
                Valor = origin.Valor,
                Descricao = origin.Descricao,
                Data = origin.Data,
                UserId = origin.UserId
            };
        }

        public PontosVO Parse(Pontos origin)
        {
            if (origin == null) return new PontosVO();
            return new PontosVO
            {
                Id = origin.Id,
                Valor = origin.Valor,
                Descricao = origin.Descricao,
                Data = origin.Data,
                UserId = origin.UserId
            };
        }

        public List<Pontos> ParseList(List<PontosVO> origin)
        {
            if (origin == null) return new List<Pontos>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PontosVO> ParseList(List<Pontos> origin)
        {
            if (origin == null) return new List<PontosVO>();
            return origin.Select(item => Parse(item)).ToList();
        }


    }
}
