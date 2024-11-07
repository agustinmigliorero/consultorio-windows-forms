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

namespace Consultorio_Medico
{
    public partial class Form2 : Form
    {
        public Form2(List<Paciente> Listpacient)
        {
            InitializeComponent();

            //se muestra el listado de pacientes
            foreach (Paciente pacientes in Listpacient)
            {
                listBoxDatosPacienteform2.Items.Add(pacientes.IdPaciente + " " + pacientes.Nombre + " " + pacientes.Apellido);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPacientesform2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDatosPacienteform2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
