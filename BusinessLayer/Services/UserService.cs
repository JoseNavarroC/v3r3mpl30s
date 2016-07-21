using BusinessLayer.Models;
using DataLayer.Entities;
using DataLayer.Repository.VacanteRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public static class UserService
    {
        public static void registerUser(UserModel model)
        {
            try
            {
                using (var repository = new UsuarioRepository())
                {


                    var user = new usuario
                    {
                        Email = model.Email,
                        Contrasenia = model.Passwod,
                        EdoConfirmacion = false,
                        Tipo = false
                    };

                    repository.DbConn.usuario.Add(user);
                    repository.DbConn.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    } 
}
