using Sistema.Model;
using Sistema.Model.Context;
using Sistema.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Repository.Implementattions
{
    public class PontosRepositoryImpl : GenericRepository<Pontos>, IPontosRepository
    {

        public PontosRepositoryImpl (MySQLContext context) : base(context) { }

        public List<Pontos> FindByUserId(Guid UserId)
        {
            return _context.Pontos.Where(p => p.UserId.Equals(UserId)).ToList();
        }
    }
}
