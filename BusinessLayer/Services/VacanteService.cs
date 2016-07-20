using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Models;
using DataLayer.Repository.VacanteRepository;

namespace BusinessLayer.Services
{
    static public class VacanteService
    {

        public static IEnumerable<VacanteModel> getVacanteBySubStr(string subStr) {

            using (var repository = new VacanteRepository()) {
                return repository.DbConn.vacante.Where(e => e.Puesto.ToLower().Contains(subStr.ToLower()))
                    .Select(e => new VacanteModel
                    {
                        Id = e.IdVacante,
                        Puesto = e.Puesto
                    }).ToList();
            }
        }
        
    }
}
