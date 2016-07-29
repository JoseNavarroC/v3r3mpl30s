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

        public static int Authenticate(string email, string password) {
            try
            {
                using (var repository = new UsuarioRepository()) {
                    var user = repository.DbConn.usuario.Where(e => e.Email == email && e.Contrasenia == password).FirstOrDefault();
                    if (user != null && user.IdUsuario > 0)
                    {
                        return user.IdUsuario;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            
        }
        public static void registerUser(UserModel model)
        {
            try
            {
                using (var repository = new UsuarioRepository())
                {


                    var user = new usuario
                    {
                        Email = model.Email,
                        Contrasenia = model.Password,
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
