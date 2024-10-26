using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_T3
{
    public class Digrafo
    {


        private readonly Dictionary<string, Usuario> usuarios;

        public Digrafo()
        {
            usuarios = new Dictionary<string, Usuario>();
        }

        public void AgregarUsuario(string user, string name, string lastName, string email, string password, string date)
        {
            if (!usuarios.ContainsKey(user))
            {
                usuarios[user] = new Usuario(name, lastName, email, user, password, date);
            }
        }

        public void AgregarRelacion(string userOrigen, string userDestino)
        {
            if (usuarios.ContainsKey(userOrigen) && usuarios.ContainsKey(userDestino))
            {
                usuarios[userOrigen].AgregarRelacion(usuarios[userDestino]);
            }
        }

        public void MostrarAdyacencias()
        {

            foreach (var usuario in usuarios.Values)
            {
                var relaciones = usuario.Relaciones;
                var nombresRelaciones = relaciones.Count > 0
                    ? string.Join(", ", relaciones.ConvertAll(r => $"{r.name} {r.last_name}"))
                    : "Nadie";

                Console.WriteLine($"{usuario.name} {usuario.last_name} ({usuario.user}) sigue a: {nombresRelaciones}");
            }
        }

    }

}
