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
    public class PontosBusinessImpl : IPontosBusiness
    {

        private IPontosRepository _repository;

        private readonly PontosConverter _converter;

        public PontosBusinessImpl(IPontosRepository repository)
        {
            _repository = repository;
            _converter = new PontosConverter();
        }

        public PontosVO Create(PontosVO obj)
        {
            var entity = _converter.Parse(obj);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public PontosVO FindById(Guid id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<PontosVO> FindByUserId(Guid id)
        {
            return _converter.ParseList(_repository.FindByUserId(id));
        }

        public List<PontosVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PontosVO Update(PontosVO obj)
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
