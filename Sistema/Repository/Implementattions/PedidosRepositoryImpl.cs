using Sistema.Model;
using Sistema.Model.Context;
using Sistema.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Repository.Implementattions
{
    public class PedidosRepositoryImpl : GenericRepository<Pedidos>, IPedidosRepository
    {

        public PedidosRepositoryImpl (MySQLContext context) : base(context) { }

        public List<Pedidos> FindByUserId(Guid UserId)
        {
            return _context.Pedidos.Where(p => p.UserId.Equals(UserId)).ToList();
        }
    }
}
