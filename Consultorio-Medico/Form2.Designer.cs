﻿namespace Consultorio_Medico
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
            SuspendLayout();
            // 
            // comboBoxPacientesform2
            // 
            comboBoxPacientesform2.FormattingEnabled = true;
            comboBoxPacientesform2.Location = new Point(29, 58);
            comboBoxPacientesform2.Name = "comboBoxPacientesform2";
            comboBoxPacientesform2.Size = new Size(271, 23);
            comboBoxPacientesform2.TabIndex = 0;
            comboBoxPacientesform2.SelectedIndexChanged += comboBoxPacientesform2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Pacientes";
            label1.Click += label1_Click;
            // 
            // listBoxDatosPacienteform2
            // 
            listBoxDatosPacienteform2.FormattingEnabled = true;
            listBoxDatosPacienteform2.ItemHeight = 15;
            listBoxDatosPacienteform2.Location = new Point(29, 109);
            listBoxDatosPacienteform2.Name = "listBoxDatosPacienteform2";
            listBoxDatosPacienteform2.Size = new Size(271, 139);
            listBoxDatosPacienteform2.TabIndex = 2;
            listBoxDatosPacienteform2.SelectedIndexChanged += listBoxDatosPacienteform2_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxDatosPacienteform2);
            Controls.Add(label1);
            Controls.Add(comboBoxPacientesform2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPacientesform2;
        private Label label1;
        private ListBox listBoxDatosPacienteform2;
    }
}