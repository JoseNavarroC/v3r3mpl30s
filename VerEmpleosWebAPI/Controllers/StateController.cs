using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Services;

namespace VerEmpleosWebAPI.Controllers
{
    public class StateController : ApiController
    {

        public IEnumerable GetState(int id)
        {
            return StateService.GetState(id);
        }
    }
}
