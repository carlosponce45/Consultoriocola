namespace Clase_4___Consultorio_con_cola
{
    public partial class Form1 : Form
    {
        Cola espera = new Cola();
        Cola sobreturno = new Cola();

        int enEspera = 1;

        public Form1()
        {
            InitializeComponent();
            //MostrarListas();
        }

        private void cmdIngreso_Click(object sender, EventArgs e)
        {
            if (enEspera > 5)
            {
                MessageBox.Show("No hay turnos disponibles");

            }
            else
            {
                NodoPaciente nuevo = new NodoPaciente(txtDNI.Text, txtApellido.Text, txtNombre.Text);
                if (enEspera <= 3)
                {
                    espera.Insertar(nuevo);
                    espera.Listar(lstEspera);
                }
                else
                {
                    sobreturno.Insertar(nuevo);
                    sobreturno.Listar(lstSobreturno);
                }
                enEspera++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (espera.inicio != null)
            {
                Form2 f2 = new Form2(espera.inicio);
                f2.Show();
                enEspera--;
                espera.Eliminar();
                if (sobreturno.inicio != null)
                {
                    NodoPaciente nuevo = new NodoPaciente(sobreturno.inicio.DNI, sobreturno.inicio.apellido, sobreturno.inicio.nombre);
                    espera.Insertar(nuevo);
                    sobreturno.Eliminar();
                }
                
                espera.Listar(lstEspera);
                sobreturno.Listar(lstSobreturno);
            }
           
        }
    }
}