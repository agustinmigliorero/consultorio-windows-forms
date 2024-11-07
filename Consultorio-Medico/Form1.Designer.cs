namespace Consultorio_Medico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxEspecialidades = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxMedicos = new ComboBox();
            button1 = new Button();
            listViewDatosPacientes = new ListView();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBoxEspecialidades
            // 
            comboBoxEspecialidades.FormattingEnabled = true;
            comboBoxEspecialidades.Location = new Point(30, 101);
            comboBoxEspecialidades.Name = "comboBoxEspecialidades";
            comboBoxEspecialidades.Size = new Size(268, 23);
            comboBoxEspecialidades.TabIndex = 0;
            comboBoxEspecialidades.SelectedIndexChanged += comboBoxEspecialidades_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 83);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Especialidades";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 193);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Medicos";
            label2.Click += label2_Click;
            // 
            // comboBoxMedicos
            // 
            comboBoxMedicos.FormattingEnabled = true;
            comboBoxMedicos.Location = new Point(30, 211);
            comboBoxMedicos.Name = "comboBoxMedicos";
            comboBoxMedicos.Size = new Size(268, 23);
            comboBoxMedicos.TabIndex = 3;
            comboBoxMedicos.SelectedIndexChanged += comboBoxMedicos_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(464, 75);
            button1.Name = "button1";
            button1.Size = new Size(228, 23);
            button1.TabIndex = 4;
            button1.Text = "Buscar Paciente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listViewDatosPacientes
            // 
            listViewDatosPacientes.Location = new Point(464, 133);
            listViewDatosPacientes.Name = "listViewDatosPacientes";
            listViewDatosPacientes.Size = new Size(228, 111);
            listViewDatosPacientes.TabIndex = 5;
            listViewDatosPacientes.UseCompatibleStateImageBehavior = false;
            listViewDatosPacientes.SelectedIndexChanged += listViewDatosPacientes_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(266, 331);
            button2.Name = "button2";
            button2.Size = new Size(228, 23);
            button2.TabIndex = 6;
            button2.Text = "Turnos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(236, 18);
            label3.Name = "label3";
            label3.Size = new Size(294, 24);
            label3.TabIndex = 7;
            label3.Text = "Sistema Consultorio Medico";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(listViewDatosPacientes);
            Controls.Add(button1);
            Controls.Add(comboBoxMedicos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxEspecialidades);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEspecialidades;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxMedicos;
        private Button button1;
        private ListView listViewDatosPacientes;
        private Button button2;
        private Label label3;
    }
}
