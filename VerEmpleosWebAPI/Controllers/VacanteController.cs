using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Models;
using BusinessLayer.Services;

namespace VerEmpleosWebAPI.Controllers
{
    public class VacanteController : ApiController
    {
        public IEnumerable<VacanteModel> Post([FromBody] string q) {

            return VacanteService.getVacanteBySubStr(q);   
        }

        public VacanteModel GetVacante(int id) {
            return VacanteService.getVacanteById(id);   
        }
    }
}
