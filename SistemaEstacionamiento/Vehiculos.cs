using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamiento.Models
{
    internal class Vehiculos
    {
        public string Patente { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public string color { get; set; }
        public override string ToString()
        {
            return $"{Patente} - {marca} {modelo} ({tipo})";
        }

    }
}
