using Sistema.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Business
{
    public interface IUserDadosBusiness
    {
        UserDadosVO Create(UserDadosVO book);
        UserDadosVO FindById(Guid id);
        List<UserDadosVO> FindAll();
        UserDadosVO Update(UserDadosVO book);
        void Delete(Guid id);

    }
}
