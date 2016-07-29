using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Services;
using VerEmpleos.Filters;

namespace VerEmpleosWebAPI.Controllers
{
    [UserAuthenticationFilter(false)]
    public class CityController : ApiController
    {

        public IEnumerable GetCity(int id)
        {
            return CityService.GetCity(id);
        }
    }
}