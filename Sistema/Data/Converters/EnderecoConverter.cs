using Sistema.Data.Converter;
using Sistema.Data.VO;
using Sistema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Data.Converters
{
    public class EnderecoConverter : IParser<EnderecoVO, Endereco>, IParser<Endereco, EnderecoVO>
    {

        public Endereco Parse(EnderecoVO origin)
        {
            if (origin == null) return new Endereco();
            return new Endereco
            {
                Nome = origin.Nome,
                Rua = origin.Rua,
                Bairro = origin.Bairro,
                Cidade = origin.Cidade,
                Estado = origin.Estado,
                Numero = origin.Numero,
                Cep = origin.Cep,
                Complemento = origin.Complemento,
                UserId = origin.UserId

            };
        }

        public EnderecoVO Parse(Endereco origin)
        {
            if (origin == null) return new EnderecoVO();
            return new EnderecoVO
            {
                Id = origin.Id,
                Nome = origin.Nome,
                Rua = origin.Rua,
                Bairro = origin.Bairro,
                Cidade = origin.Cidade,
                Estado = origin.Estado,
                Numero = origin.Numero,
                Cep = origin.Cep,
                Complemento = origin.Complemento,
                UserId = origin.UserId

            };
        }

        public List<Endereco> ParseList(List<EnderecoVO> origin)
        {
            if (origin == null) return new List<Endereco>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<EnderecoVO> ParseList(List<Endereco> origin)
        {
            if (origin == null) return new List<EnderecoVO>();
            return origin.Select(item => Parse(item)).ToList();
        }


    }
}
