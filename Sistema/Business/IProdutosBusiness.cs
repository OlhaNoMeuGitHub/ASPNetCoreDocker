using Sistema.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Business
{
    public interface IProdutosBusiness
    {
        ProdutosVO Create(ProdutosVO obj);
        ProdutosVO FindById(Guid id);
        List<ProdutosVO> FindAll();
        ProdutosVO Update(ProdutosVO obj);
        void Delete(Guid id);

    }
}
