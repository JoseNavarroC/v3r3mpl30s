using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Models;
using DataLayer.Repository.VacanteRepository;

namespace BusinessLayer.Services
{
    static public class VacanteService
    {

        public static IEnumerable<VacanteModel> getVacanteBySubStr(string subStr)
        {
            try
            {
                using (var repository = new VacanteRepository())
                {
                    return repository.DbConn.vacante.Where(e => e.Puesto.ToLower().Contains(subStr.ToLower()))
                        .Select(e => new VacanteModel
                        {
                            IdVacante = e.IdVacante,
                            Puesto = e.Puesto
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
       
        public static VacanteModel getVacanteById(int Id)
        {
            try
            {
                using (var repository = new VacanteRepository())
                {
                    return repository.DbConn.vacante.Where(e => e.IdVacante == Id)
                        .Select(e => new VacanteModel
                        {
                            IdVacante = e.IdVacante,
                            DescripcionPuesto = e.DescripcionPuesto,
                            Activa = e.Activa,
                            IdPais = e.IdPais,
                            IdUsuario = e.IdUsuario,
                            Puesto = e.Puesto,
                            PalabrasClave = e.PalabrasClave,
                            DireccionDelTrabajo = e.DireccionDeTrabajo,
                            MostrarDireccion = e.MostrarDireccion,
                            RecibirCVEnPanel = e.RecibirCVEnPanel,
                            IdArea = e.IdArea,
                            IdSubArea = e.IdSubArea,
                            IdEstado = e.IdEstado,
                            ReqExperienciaMinima = e.ReqEdadMinima,
                            ReqEdadMinima = e.ReqEdadMinima,
                            ReqEdadMaxima = e.ReqEdadMaxima,
                            ReqTipoEdad = e.ReqTipoEdad,
                            ReqGenero = e.ReqGenero,
                            ReqSalarioMinimo = e.ReqSalarioMinimo,
                            ReqSalarioMaximo = e.ReqSalarioMaximo,
                            ReqSalarioTipoPago = e.ReqSalarioTipoPago,
                            ReqSalarioForemaPago = e.ReqSalarioFormaPago,
                            ReqMostrarEnAviso = e.ReqMostrarEnAviso,
                            ReqSolicitarSalarioPostulan = e.ReqSolicitarSalarioPostulante,
                            ReqTecnologia = e.ReqTecnologia,
                            FechaPublicacion = e.FechaPublicacion,
                            FechaFinPublicacion = e.FechaFinPublicacion ?? default(DateTime),
                            NotRecibirTodo = e.NotRecibirTodo,
                            NotRecibirResumen = e.NotRecibirResumen,
                            NotPrimerPostulante = e.NotPrimerPostulante,
                            NotDesactivarNotificaciones = e.NotDesactivarNotificaciones,
                            TipoPuesto = e.TipoPuesto,
                            IdIdioma = e.IdIdioma,
                            IdNivelIdioma = e.IdNivelIdioma,
                            IdEduacion = e.IdEducacion,
                            IdEstatusEducacion = e.IdEstatusEducacion,
                            Vistas = e.Vistas,
                            Actividad = e.Actividad, 
                            IdGeolocalizacion = e.IdGeolocalizacion,

               
                      
                        }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public class Entity<T>
        {
        }
    }
}