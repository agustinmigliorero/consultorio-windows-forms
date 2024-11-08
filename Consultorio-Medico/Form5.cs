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
using Entidades;
using CapaDatos;

namespace Consultorio_Medico
{
    public partial class Form5 : Form
    { 

    public Paciente DatoPaciente { get; set; }
    public Medico DatoMedico { get; set; }
    public Form5(Paciente DatosPacienteSelecionado, Medico DatosMedicoSeleccionado)
        {
            InitializeComponent();
            DatoMedico=DatosMedicoSeleccionado;
            DatoPaciente=DatosPacienteSelecionado;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try {
                List<Turno> HistorialTurnos = DataTurno.VerTurnosPorPaciente(DatoPaciente.IdPaciente);
                foreach (Turno turno in HistorialTurnos)
                {
                    Medico medico = DataMedico.VerMedico(Convert.ToSByte(turno.IdMedico));
                    listView2.Items.Add(turno.Fecha.ToString() + " " + medico.NombreCompleto);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Antes debes elegir un paciente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void labelHoraDispo_Click(object sender, EventArgs e)
        {

        }

        private void labelfechaturno_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            comboBox1.Items.Clear();
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
            List<Turno> turnosmedico = DataTurno.VerTurnosPorMedicoYFecha(DatoMedico.IdMedico,fechaSeleccionada);
            List<Agenda> horariosmedico = DataAgenda.VerAgenda(DatoMedico.IdMedico);

            HashSet<TimeSpan> horariosOcupados = new HashSet<TimeSpan>();

            foreach (Turno turno in turnosmedico) { 
                horariosOcupados.Add(turno.Fecha.TimeOfDay); 
            }

            foreach (Agenda horario in horariosmedico)
            {
                if (!horariosOcupados.Contains(horario.Horario))
                {
                    comboBox1.Items.Add(horario.Horario.ToString(@"hh\:mm"));
                }
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttongenerarturno_Click(object sender, EventArgs e)
        {

        }

        private void buttoncancelarTurno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void labelHistorialturno_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
