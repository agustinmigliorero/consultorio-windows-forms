using static System.Runtime.InteropServices.JavaScript.JSType;
using CapaDatos;
using Entidades;

namespace Consultorio_Medico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carga de la base de datos las especialidades
            List<Especialidad> especialidades = Datos.CargarEspecialidades();
            //muestra la lista de especialidades
            foreach (Especialidad especialidad in especialidades)
            {
                comboBoxEspecialidades.Items.Add(especialidad.IdEspecialidad + " " + especialidad.Nombre);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listViewDatosPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
