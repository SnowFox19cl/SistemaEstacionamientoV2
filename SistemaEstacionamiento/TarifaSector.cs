using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamiento.Models
{
    internal class TarifaSector
    {
        public int id { get; set; }
        public string NombreSector { get; set; }
        public decimal costoHora { get; set; }

        public override string ToString()
        {
            return $"{NombreSector} - ${costoHora}/hora";
        }
    }
}
