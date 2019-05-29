using Microsoft.AspNetCore.Mvc;
using Sistema.Business;
using Microsoft.AspNetCore.Authorization;
using Sistema.Data.VO;

namespace Sistema.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LoginController : Controller
    {
        private ILoginBusiness _loginBusiness;

        public LoginController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [AllowAnonymous]
        [HttpPost]
        public object Post([FromBody]UserVO user)
        {
            if (user == null) return BadRequest();
            return _loginBusiness.FindByLogin(user);
        }


    }
}
