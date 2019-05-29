using Sistema.Model;
using Sistema.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Repository
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        List<Endereco> FindByUserId(Guid UserId);
        
    }
}
