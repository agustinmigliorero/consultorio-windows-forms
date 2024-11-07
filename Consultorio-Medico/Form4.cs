using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Consultorio_Medico
{
    public partial class Form4 : Form
    {
        Paciente Datospacient { get; set; }
        public Form4(Paciente Datospaciente)
        {
            InitializeComponent();
            Datospacient = Datospaciente;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBoxnombre.Text = Datospacient.Nombre;
            textBoxapellido.Text = Datospacient.Apellido;
            textBoxdni.Text = Datospacient.DNI;
            textBoxHisclin.Text = Datospacient.HistoriaClinica;
            textBoxnotas.Text = Datospacient.Notas;
            textBoxtel.Text = Datospacient.Telefono;
            textBoxtelfijo.Text = Datospacient.TelefonoFijo;
            dateTimePickerFechNaci.Value = Convert.ToDateTime(Datospacient.FechaNacimiento);
        }

        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditarpaciente_Click(object sender, EventArgs e)
        {
            Paciente PacienteEditado= new Paciente();
            PacienteEditado.IdPaciente=Datospacient.IdPaciente;
            PacienteEditado.Nombre=textBoxnombre.Text;
            PacienteEditado.Apellido=textBoxapellido.Text;
            PacienteEditado.DNI=textBoxdni.Text;
            PacienteEditado.FechaNacimiento= dateTimePickerFechNaci.Value;
            PacienteEditado.HistoriaClinica=textBoxHisclin.Text;
            PacienteEditado.Notas=textBoxnotas.Text;
            PacienteEditado.Telefono=textBoxtel.Text;   
            PacienteEditado.TelefonoFijo=textBoxtelfijo.Text;
            DataPaciente.EditarPaciente(PacienteEditado);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
