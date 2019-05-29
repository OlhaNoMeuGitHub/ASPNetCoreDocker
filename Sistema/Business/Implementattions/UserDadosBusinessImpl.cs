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
    public class UserDadosBusinessImpl : IUserDadosBusiness
    {

        private IRepository<User> _repository;

        private readonly UserDadosConverter _converter;

        public UserDadosBusinessImpl(IRepository<User> repository)
        {
            _repository = repository;
            _converter = new UserDadosConverter();
        }

        public UserDadosVO Create(UserDadosVO obj)
        {
            var entity = _converter.Parse(obj);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public UserDadosVO FindById(Guid id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<UserDadosVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public UserDadosVO Update(UserDadosVO obj)
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
