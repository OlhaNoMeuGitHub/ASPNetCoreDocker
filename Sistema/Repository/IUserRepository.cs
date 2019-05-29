using Sistema.Model;
using System.Collections.Generic;

namespace Sistema.Repository
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
    }
}
