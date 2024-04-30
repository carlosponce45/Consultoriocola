using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4___Consultorio_con_cola
{
    public class NodoPaciente
    {
        public string DNI;
        public string apellido;
        public string nombre;

        public NodoPaciente siguiente;

        public NodoPaciente(string DNI, string apellido, string nombre)
        { 
            this.DNI = DNI;
            this.apellido = apellido;
            this.nombre = nombre;
            this.siguiente = null;
        }
    }
}
