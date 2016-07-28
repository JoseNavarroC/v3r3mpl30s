using System;
using System.Collections.Generic;
using System.Linq;

using BusinessLayer.Models;
using DataLayer.Repository.VacanteRepository;

namespace BusinessLayer.Services
{
    static public class CityService
    {
        public static IEnumerable<CityModel> GetCity(int IdEstado)
        {
            try
            {
                using (var repository = new CityRepository())
                {
                    return repository.DbConn.ciudad.Where(e => e.idEstado == IdEstado)
                        .Select(e => new CityModel
                        {
                            IdCity = e.idCiudad,
                            City = e.Ciudad1,
                            IdState = e.idEstado,
                           
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

