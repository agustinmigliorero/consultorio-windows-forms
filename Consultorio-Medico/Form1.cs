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

        private void Form1_Load(object sender, EventArgs e)
        {
            //carga de la base de datos las especialidades
            List<Especialidad> especialidades = DataEspecialidad.CargarEspecialidades();
            //muestra la lista de especialidades
            foreach (Especialidad especialidad in especialidades)
            {
                comboBoxEspecialidades.Items.Add(especialidad.IdEspecialidad + " " + especialidad.Nombre);
            }

        }
        private void comboBoxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //toma el valor del id de la especialidad y lo guarda
            var especialidadId = Convert.ToSByte(comboBoxEspecialidades.SelectedItem.ToString().Split(' ')[0]);
            //carga de la base de datos la lista de medicos que tienen esa especialidad
            List<Medico> Medicos = DataMedico.VerMedicosPorEspecialidad(especialidadId);
            comboBoxMedicos.Items.Clear();
            //muestra la lista de medicos recien cargada
            foreach (Medico medicos in Medicos)
            {
                comboBoxMedicos.Items.Add(medicos.IdMedico + " " + medicos.Apellido + " " + medicos.Nombre);
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
            List<Paciente> Pacientes = DataPaciente.VerPacientes();
            // Crea una instancia del nuevo formulario (Form2)
            Form2 nuevoFormulario = new Form2(Pacientes);
            // Mostrar el nuevo formulario. 
            nuevoFormulario.ShowDialog();
            //muestra los datos del cliente seleccionado en la panatalla form2 para ser udados en vistos en esta
            /*if (nuevoFormulario. != null)
            {
                DatosPacienteSelecionado = nuevoFormulario.Datospaci;
                PacienteSeleccionado.Items.Clear();
                PacienteSeleccionado.Items.Add(nuevoFormulario.Datospaci.IDPaciente.ToString());
                PacienteSeleccionado.Items.Add(DatosPacienteSelecionado.Apellido + " " + DatosPacienteSelecionado.Nombre);
                PacienteSeleccionado.Items.Add(DatosPacienteSelecionado.Dni);
                PacienteSeleccionado.Items.Add(DatosPacienteSelecionado.MRN.ToString());
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listViewDatosPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
