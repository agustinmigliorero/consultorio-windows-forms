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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e) {
            btnInvisible.Focus();
        }


        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtelfijo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHisclin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechNaci_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnotas_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCrearpaciente_Click(object sender, EventArgs e)
        {
            Paciente Creapaciente = new Paciente();
            Creapaciente.Nombre= textBoxnombre.Text;
            Creapaciente.Apellido= textBoxapellido.Text;
            Creapaciente.DNI= textBoxdni.Text;
            Creapaciente.FechaNacimiento = Convert.ToDateTime(dateTimePickerFechNaci.Text);
            Creapaciente.HistoriaClinica= textBoxHisclin.Text;
            Creapaciente.Telefono=textBoxtel.Text;
            Creapaciente.TelefonoFijo= textBoxtelfijo.Text;
            Creapaciente.Notas= textBoxnotas.Text; 

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
