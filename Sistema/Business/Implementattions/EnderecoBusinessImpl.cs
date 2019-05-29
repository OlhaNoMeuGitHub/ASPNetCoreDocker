using Sistema.Data.Converters;
using Sistema.Data.VO;
using Sistema.Model;
using Sistema.Repository;
using Sistema.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Business.Implementattions
{
    public class EnderecoBusinessImpl : IEnderecoBusiness
    {

        private IEnderecoRepository _repository;

        private readonly EnderecoConverter _converter;

        public EnderecoBusinessImpl(IEnderecoRepository repository)
        {
            _repository = repository;
            _converter = new EnderecoConverter();
        }

        public EnderecoVO Create(EnderecoVO obj)
        {
            var entity = _converter.Parse(obj);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public EnderecoVO FindById(Guid id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<EnderecoVO> FindByUserId(Guid id)
        {
            return _converter.ParseList(_repository.FindByUserId(id));
        }

        public List<EnderecoVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public EnderecoVO Update(EnderecoVO obj)
        {
            var entity = _converter.Parse(obj);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public bool Exists(Guid id)
        {
            return _repository.Exists(id);
        }
    }
}
