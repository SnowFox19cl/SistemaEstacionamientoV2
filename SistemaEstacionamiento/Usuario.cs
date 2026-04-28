using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamiento.Models
{
    internal class Usuario
    {
        public string username { get; set; }
        public string contraseña { get; set; }

        public static bool Validar(string username, string contraseña)
        {
            if (username == "admin" && contraseña == "admin123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
