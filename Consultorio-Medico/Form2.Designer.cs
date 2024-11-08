namespace Consultorio_Medico
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxPacientesform2 = new ComboBox();
            label1 = new Label();
            listBoxDatosPacienteform2 = new ListBox();
            Siguiente = new Button();
            botoncrearPaciente = new Button();
            buttonEditarpac = new Button();
            buttonmodifcarestado = new Button();
            SuspendLayout();
            // 
            // comboBoxPacientesform2
            // 
            comboBoxPacientesform2.BackColor = Color.FromArgb(192, 255, 255);
            comboBoxPacientesform2.FormattingEnabled = true;
            comboBoxPacientesform2.Location = new Point(29, 58);
            comboBoxPacientesform2.Name = "comboBoxPacientesform2";
            comboBoxPacientesform2.Size = new Size(271, 23);
            comboBoxPacientesform2.TabIndex = 0;
            comboBoxPacientesform2.SelectedIndexChanged += comboBoxPacientesform2_SelectedIndexChanged;
            comboBoxPacientesform2.Click += comboBoxPacientesform2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 1;
            label1.Text = "Pacientes";
            label1.Click += label1_Click;
            // 
            // listBoxDatosPacienteform2
            // 
            listBoxDatosPacienteform2.BackColor = Color.FromArgb(192, 255, 255);
            listBoxDatosPacienteform2.FormattingEnabled = true;
            listBoxDatosPacienteform2.ItemHeight = 15;
            listBoxDatosPacienteform2.Location = new Point(29, 109);
            listBoxDatosPacienteform2.Name = "listBoxDatosPacienteform2";
            listBoxDatosPacienteform2.Size = new Size(271, 139);
            listBoxDatosPacienteform2.TabIndex = 2;
            listBoxDatosPacienteform2.SelectedIndexChanged += listBoxDatosPacienteform2_SelectedIndexChanged;
            // 
            // Siguiente
            // 
            Siguiente.BackColor = Color.LightSeaGreen;
            Siguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Siguiente.Location = new Point(339, 313);
            Siguiente.Name = "Siguiente";
            Siguiente.Size = new Size(102, 50);
            Siguiente.TabIndex = 3;
            Siguiente.Text = "Siguiente";
            Siguiente.UseVisualStyleBackColor = false;
            Siguiente.Click += Siguiente_Click;
            // 
            // botoncrearPaciente
            // 
            botoncrearPaciente.BackColor = Color.GreenYellow;
            botoncrearPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botoncrearPaciente.Location = new Point(487, 74);
            botoncrearPaciente.Name = "botoncrearPaciente";
            botoncrearPaciente.Size = new Size(222, 36);
            botoncrearPaciente.TabIndex = 4;
            botoncrearPaciente.Text = "Crear Paciente";
            botoncrearPaciente.UseVisualStyleBackColor = false;
            botoncrearPaciente.Click += botoncrearPaciente_Click;
            // 
            // buttonEditarpac
            // 
            buttonEditarpac.BackColor = Color.Aquamarine;
            buttonEditarpac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditarpac.Location = new Point(487, 131);
            buttonEditarpac.Name = "buttonEditarpac";
            buttonEditarpac.Size = new Size(221, 36);
            buttonEditarpac.TabIndex = 5;
            buttonEditarpac.Text = "Editar Paciente";
            buttonEditarpac.UseVisualStyleBackColor = false;
            buttonEditarpac.Click += buttonEditarpac_Click;
            // 
            // buttonmodifcarestado
            // 
            buttonmodifcarestado.BackColor = Color.Salmon;
            buttonmodifcarestado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonmodifcarestado.Location = new Point(487, 194);
            buttonmodifcarestado.Name = "buttonmodifcarestado";
            buttonmodifcarestado.Size = new Size(221, 36);
            buttonmodifcarestado.TabIndex = 6;
            buttonmodifcarestado.Text = "Modificar Estado";
            buttonmodifcarestado.UseVisualStyleBackColor = false;
            buttonmodifcarestado.Click += buttonmodifcarestado_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonmodifcarestado);
            Controls.Add(buttonEditarpac);
            Controls.Add(botoncrearPaciente);
            Controls.Add(Siguiente);
            Controls.Add(listBoxDatosPacienteform2);
            Controls.Add(label1);
            Controls.Add(comboBoxPacientesform2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPacientesform2;
        private Label label1;
        private ListBox listBoxDatosPacienteform2;
        private Button Siguiente;
        private Button botoncrearPaciente;
        private Button buttonEditarpac;
        private Button buttonmodifcarestado;
    }
}