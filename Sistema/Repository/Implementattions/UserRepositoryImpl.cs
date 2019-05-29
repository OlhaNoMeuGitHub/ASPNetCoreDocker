using Sistema.Model;
using Sistema.Model.Context;
using System.Linq;

namespace Sistema.Repository.Implementattions
{
    public class UserRepositoryImpl : IUserRepository
    {
        private readonly MySQLContext _context;

        public UserRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(u => u.Email.Equals(login));
        }
    }
}
