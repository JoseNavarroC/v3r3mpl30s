using BusinessLayer.Models;
using BusinessLayer.Services;
using System.Web.Http;

namespace VerEmpleosWebAPI.Controllers
{
    public class RegisterUserController : ApiController
    {
        public void Post([FromBody] UserModel model)
        {
            UserService.registerUser(model);
        }
    }
}
