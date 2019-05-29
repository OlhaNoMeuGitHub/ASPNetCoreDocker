using Sistema.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Business
{
    public interface IPontosBusiness
    {
        PontosVO Create(PontosVO obj);
        PontosVO FindById(Guid id);
        List<PontosVO> FindByUserId(Guid id);
        List<PontosVO> FindAll();
        PontosVO Update(PontosVO obj);
        void Delete(Guid id);

    }
}
