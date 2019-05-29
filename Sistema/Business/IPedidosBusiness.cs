using Sistema.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Business
{
    public interface IPedidosBusiness
    {
        PedidosVO Create(PedidosVO obj);
        PedidosVO FindById(Guid id);
        List<PedidosVO> FindByUserId(Guid id);
        List<PedidosVO> FindAll();
        PedidosVO Update(PedidosVO obj);
        void Delete(Guid id);

    }
}
