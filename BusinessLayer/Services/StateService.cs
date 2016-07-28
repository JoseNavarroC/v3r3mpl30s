using System;
using System.Collections.Generic;
using System.Linq;

using BusinessLayer.Models;
using DataLayer.Repository.VacanteRepository;

namespace BusinessLayer.Services
{
    static public class StateService
    {
        public static IEnumerable<StateModel> GetState(int IdPais)
        {
            try
            {
                using (var repository = new StateRespository())
                {
                    return repository.DbConn.estado.Where(e => e.idPais == IdPais)
                        .Select(e => new StateModel
                        {
                            idState = e.idEstado,
                            State = e.Estado1,
                            IdCountry = e.idPais,
                        }).ToList();
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
