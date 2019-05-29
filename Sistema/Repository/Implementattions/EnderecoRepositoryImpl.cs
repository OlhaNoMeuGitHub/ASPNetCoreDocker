using Sistema.Model;
using Sistema.Model.Context;
using Sistema.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Sistema.Repository.Implementattions
{
    public class EnderecoRepositoryImpl : GenericRepository<Endereco>, IEnderecoRepository
    {

        public EnderecoRepositoryImpl(MySQLContext context) : base(context) { }

        public List<Endereco> FindByUserId(Guid UserId)
        {
            return _context.Enderecos.Where(p => p.UserId.Equals(UserId)).ToList();
        }
    }
}
