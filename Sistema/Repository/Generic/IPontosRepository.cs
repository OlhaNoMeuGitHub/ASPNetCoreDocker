using Sistema.Model;
using Sistema.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Sistema.Repository.Generic
{
    public interface IPontosRepository : IRepository<Pontos>
    {
        List<Pontos> FindByUserId(Guid UserId);

    }
}
