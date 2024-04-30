using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4___Consultorio_con_cola
{
    internal class Cola
    {
        public NodoPaciente inicio;
        public NodoPaciente fin;

        public void Insertar(NodoPaciente paciente)
        { 
            if (inicio == null)
            {
                inicio = paciente;
                fin = paciente;
            }
            else
            {
                fin.siguiente = paciente;
                fin = paciente;
            }
        }
        public void Listar(ListBox lstEspera)
        { 
            lstEspera.Items.Clear();
            if (inicio == null) lstEspera.Items.Add("No hay pacientes");
            else
            {
                NodoPaciente aux = inicio;
                while(aux != null)
                {
                    lstEspera.Items.Add(aux.DNI + " - " + aux.apellido + ", " + aux.nombre);
                    aux = aux.siguiente;
                }
            }
        }
        public void Eliminar()
        {
            if (inicio != null)
            {
                NodoPaciente aux = inicio;
                inicio = aux.siguiente;
                aux = null;

                if (inicio == null) fin = null;
            }
        }
    }
}
