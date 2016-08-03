using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class UserModel : GenericIdentity
    {
        public int IdUser { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }


        public UserModel() : base("Basic")
        {

        }
        public UserModel(string userName, string password)
            : base(userName, "Basic")
        {
            Password = password;
            Email = userName;
        }
    }

    
}
