using BusinessLayer.Models;
using BusinessLayer.Services;
using System.Web.Http;
using VerEmpleos.Filters;

namespace VerEmpleosWebAPI.Controllers
{
    [UserAuthenticationFilter(false)]
    public class RegisterUserController : ApiController
    {
        public void Post([FromBody] UserModel model)
        {
            UserService.registerUser(model);
        }
    }
}
