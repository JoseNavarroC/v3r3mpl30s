using BusinessLayer.Models;
using BusinessLayer.Services;
using System.Web.Http;
using VerEmpleos.Filters;
using System.Net.Http;
using System.Net;

namespace VerEmpleosWebAPI.Controllers
{
    [UserAuthenticationFilter(false)]
    public class RegisterUserController : ApiController
    {
        public HttpResponseMessage Post([FromBody] UserModel model)
        {
            var res = UserService.registerUser(model);
            if (res == true)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Se registro usuario con éxito");
                return response;
            }
            else {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.InternalServerError, "Error al registrar usuario");
                return response;
            }
        }
    }
}
