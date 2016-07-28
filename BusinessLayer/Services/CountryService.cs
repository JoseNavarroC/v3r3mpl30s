using System;
using System.Collections.Generic;
using System.Linq;

using BusinessLayer.Models;
using DataLayer.Repository.VacanteRepository;

namespace BusinessLayer.Services
{
    static public class CountryService
    {
         public static IEnumerable<CountryModel> GetAllCountries()
        {
            try
            {
                using (var repository = new CountryRespository())
                {
                    return repository.DbConn.pais
                        .Select(e => new CountryModel
                        {
                            id = e.idPais,
                            name = e.Pais1
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
