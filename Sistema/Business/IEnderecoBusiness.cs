using Sistema.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Business
{
    public interface IEnderecoBusiness
    {
        EnderecoVO Create(EnderecoVO obj);
        EnderecoVO FindById(Guid id);
        List<EnderecoVO> FindByUserId(Guid id);
        List<EnderecoVO> FindAll();
        EnderecoVO Update(EnderecoVO obj);
        void Delete(Guid id);

    }
}
