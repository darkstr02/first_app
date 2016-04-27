using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoOT
{
    public static class CredencialUsuario
    {
        public static string Nombre;
        public static string Permiso;

        public static int SubscribirCuenta(string nombre, string permiso)
        {
            Nombre = nombre;
            Permiso = permiso;

            return 0;
        }


    }
}
