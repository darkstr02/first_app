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
        public static string Contrasena;

        public static int SubscribirCuenta(string nombre, string permiso, string contra)
        {
            Nombre = nombre;
            Permiso = permiso;
            Contrasena = contra;
            return 0;
        }


    }
}
