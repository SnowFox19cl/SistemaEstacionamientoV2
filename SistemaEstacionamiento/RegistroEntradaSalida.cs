using SistemaEstacionamiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamiento.Models
{
    internal class RegistroEntradaSalida
    {
        public int id { get; set; }
        public Vehiculos vehiculoAsignado { get; set; }
        public TarifaSector sectorAsignado { get; set; }
        public DateTime horaEntrada { get; set; }
        public DateTime? horaSalida { get; set; }
        public decimal TotalPagado { get; set; }

    }
}
