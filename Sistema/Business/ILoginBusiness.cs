using Sistema.Data.VO;
using Sistema.Model;
using System.Collections.Generic;

namespace Sistema.Business
{
    public interface ILoginBusiness
    {

        object FindByLogin(UserVO user);

    }
}
