using System.Collections.Generic;
using System.Web.Http;
using BusinessLayer.Models;
using BusinessLayer.Services;
using VerEmpleos.Filters;

namespace VerEmpleosWebAPI.Controllers
{
    [UserAuthenticationFilter(true)]
    public class VacanteAdvancedSearchController : ApiController
    {
        public IEnumerable<VacanteModel> Post([FromBody] VacanteModel model)
        {
            return VacanteService.getVacanteAdvanceSeach(model);
        }
    }
}
