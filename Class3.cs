using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_reapao__1
{
    class Sueldo
    {
        String nombreEmpleado;
        int mes;
        Decimal sueldoMensual;

        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public decimal SueldoMensual { get => sueldoMensual; set => sueldoMensual = value; }
        public int Mes { get => mes; set => mes = value; }
    }
}
