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
    public class PedidosBusinessImpl : IPedidosBusiness
    {

        private IPedidosRepository _repository;

        private readonly PedidosConverter _converter;

        public PedidosBusinessImpl(IPedidosRepository repository)
        {
            _repository = repository;
            _converter = new PedidosConverter();
        }

        public PedidosVO Create(PedidosVO obj)
        {
            var entity = _converter.Parse(obj);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public PedidosVO FindById(Guid id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<PedidosVO> FindByUserId(Guid id)
        {
            return _converter.ParseList(_repository.FindByUserId(id));
        }

        public List<PedidosVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PedidosVO Update(PedidosVO obj)
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
