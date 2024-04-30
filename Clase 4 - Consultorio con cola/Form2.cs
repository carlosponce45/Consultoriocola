using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_4___Consultorio_con_cola
{
    public partial class Form2 : Form
    {
        public Form2(NodoPaciente paciente)
        {
            InitializeComponent();
           lblApellidoNombre.Text   = paciente.apellido + ", " + paciente.nombre;
            lblDNI.Text = paciente.DNI;

        }
    }
}
