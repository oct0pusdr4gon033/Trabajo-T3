using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_T3
{
    public class Usuario
    {

        public string name;
        public string last_name;
        public string user;
        public string email;
        public string password;
        public string date; 

        public List<Usuario> Relaciones { get;  } 


        public Usuario(string name, string last_name, string email, string user, string password, string date) 
        {

            this.name = name;
            this.last_name = last_name;
            this.email = email;
            this.user = user;
            this.password = password;
            this.date = date;
        }
        public void AgregarRelacion(Usuario usuario)
        {
            Relaciones.Add(usuario);
        }


    }
}
