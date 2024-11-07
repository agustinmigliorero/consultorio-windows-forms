using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Consultorio_Medico
{
    public partial class Form2 : Form
    {
        public Paciente Datospaciente { get; set; }
        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPacientesform2_Click(object sender, EventArgs e)
        {
            comboBoxPacientesform2.Items.Clear();
            List<Paciente> Listpacient;
            Listpacient = DataPaciente.VerPacientes();
            //se muestra el listado de pacientes
            foreach (Paciente pacientes in Listpacient)
            {
                comboBoxPacientesform2.Items.Add(pacientes.IdPaciente + " " + pacientes.Nombre + " " + pacientes.Apellido);
            }
        }

        private void comboBoxPacientesform2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //toma el valor del id del paciente y se utiliza para mostrarlo
            var idpaciente = Convert.ToSByte(comboBoxPacientesform2.SelectedItem.ToString().Split(' ')[0]);
            Datospaciente = DataPaciente.VerPaciente(idpaciente);
            listBoxDatosPacienteform2.Items.Clear();
            listBoxDatosPacienteform2.Items.Add("N° Paciente: " + Datospaciente.IdPaciente);
            listBoxDatosPacienteform2.Items.Add("Apellido y Nombre: " + Datospaciente.NombreCompleto);
            listBoxDatosPacienteform2.Items.Add("DNI: " + Datospaciente.DNI);
            listBoxDatosPacienteform2.Items.Add("MRN: " + Datospaciente.HistoriaClinica);
            listBoxDatosPacienteform2.Items.Add("Fecha Nacimiento: " + Datospaciente.FechaNacimiento);
            listBoxDatosPacienteform2.Items.Add("Telefono: " + Datospaciente.Telefono);
            listBoxDatosPacienteform2.Items.Add("Telefono Fijo: " + Datospaciente.TelefonoFijo);
            listBoxDatosPacienteform2.Items.Add("Notas: " + Datospaciente.Notas);
            listBoxDatosPacienteform2.Items.Add("Estado: " + Datospaciente.Estado);
        }

        private void listBoxDatosPacienteform2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado algo en el ComboBox
            if (comboBoxPacientesform2.SelectedItem != null)
            {
                // Cerrar este formulario para volver al formulario anterior
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void botoncrearPaciente_Click(object sender, EventArgs e)
        {
            Form3 nuevoFormulario = new Form3();
            nuevoFormulario.ShowDialog();
        }

        private void buttonEditarpac_Click(object sender, EventArgs e)
        {
            Form4 nuevoFormulario = new Form4(Datospaciente);
            nuevoFormulario.ShowDialog();
        }
    }
}
