using Sistema.Data.Converters;
using Sistema.Data.VO;
using Sistema.Model;
using Sistema.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Business.Implementattions
{
    public class ProdutosBusinessImpl : IProdutosBusiness
    {

        private IRepository<Produtos> _repository;

        private readonly ProdutosConverter _converter;

        public ProdutosBusinessImpl(IRepository<Produtos> repository)
        {
            _repository = repository;
            _converter = new ProdutosConverter();
        }

        public ProdutosVO Create(ProdutosVO obj)
        {
            var entity = _converter.Parse(obj);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }
        public ProdutosVO FindById(Guid id)
        {
            return _converter.Parse(_repository.FindById(id));
        }
        public List<ProdutosVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public ProdutosVO Update(ProdutosVO obj)
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
