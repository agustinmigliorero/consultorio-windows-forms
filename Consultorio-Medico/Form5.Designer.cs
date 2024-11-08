namespace Consultorio_Medico
{
    partial class Form5
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
            monthCalendar1 = new MonthCalendar();
            comboBox1 = new ComboBox();
            labelfechaturno = new Label();
            labelHoraDispo = new Label();
            buttongenerarturno = new Button();
            buttoncancelarTurno = new Button();
            listView2 = new ListView();
            labelHistorialturno = new Label();
            buttoneditarturno = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(70, 36);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.MenuBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(53, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelfechaturno
            // 
            labelfechaturno.AutoSize = true;
            labelfechaturno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelfechaturno.Location = new Point(70, 12);
            labelfechaturno.Name = "labelfechaturno";
            labelfechaturno.Size = new Size(74, 15);
            labelfechaturno.TabIndex = 2;
            labelfechaturno.Text = "Fecha Turno";
            labelfechaturno.Click += labelfechaturno_Click;
            // 
            // labelHoraDispo
            // 
            labelHoraDispo.AutoSize = true;
            labelHoraDispo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHoraDispo.Location = new Point(53, 224);
            labelHoraDispo.Name = "labelHoraDispo";
            labelHoraDispo.Size = new Size(120, 15);
            labelHoraDispo.TabIndex = 3;
            labelHoraDispo.Text = "Horarios Disponibles";
            labelHoraDispo.Click += labelHoraDispo_Click;
            // 
            // buttongenerarturno
            // 
            buttongenerarturno.BackColor = Color.PaleGreen;
            buttongenerarturno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttongenerarturno.Location = new Point(28, 319);
            buttongenerarturno.Name = "buttongenerarturno";
            buttongenerarturno.Size = new Size(106, 23);
            buttongenerarturno.TabIndex = 4;
            buttongenerarturno.Text = "Generar Turno";
            buttongenerarturno.UseVisualStyleBackColor = false;
            buttongenerarturno.Click += buttongenerarturno_Click;
            // 
            // buttoncancelarTurno
            // 
            buttoncancelarTurno.BackColor = Color.Salmon;
            buttoncancelarTurno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoncancelarTurno.Location = new Point(275, 319);
            buttoncancelarTurno.Name = "buttoncancelarTurno";
            buttoncancelarTurno.Size = new Size(110, 23);
            buttoncancelarTurno.TabIndex = 5;
            buttoncancelarTurno.Text = "Cancelar Turno";
            buttoncancelarTurno.UseVisualStyleBackColor = false;
            buttoncancelarTurno.Click += buttoncancelarTurno_Click;
            // 
            // listView2
            // 
            listView2.BackColor = SystemColors.ControlLight;
            listView2.Location = new Point(454, 36);
            listView2.Name = "listView2";
            listView2.Size = new Size(307, 306);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.List;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // labelHistorialturno
            // 
            labelHistorialturno.AutoSize = true;
            labelHistorialturno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistorialturno.Location = new Point(454, 12);
            labelHistorialturno.Name = "labelHistorialturno";
            labelHistorialturno.Size = new Size(110, 15);
            labelHistorialturno.TabIndex = 8;
            labelHistorialturno.Text = "Historial de Turnos";
            labelHistorialturno.Click += labelHistorialturno_Click;
            // 
            // buttoneditarturno
            // 
            buttoneditarturno.BackColor = Color.Pink;
            buttoneditarturno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoneditarturno.Location = new Point(150, 319);
            buttoneditarturno.Name = "buttoneditarturno";
            buttoneditarturno.Size = new Size(110, 23);
            buttoneditarturno.TabIndex = 9;
            buttoneditarturno.Text = "Editar Turno";
            buttoneditarturno.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttoneditarturno);
            Controls.Add(labelHistorialturno);
            Controls.Add(listView2);
            Controls.Add(buttoncancelarTurno);
            Controls.Add(buttongenerarturno);
            Controls.Add(labelHoraDispo);
            Controls.Add(labelfechaturno);
            Controls.Add(comboBox1);
            Controls.Add(monthCalendar1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ComboBox comboBox1;
        private Label labelfechaturno;
        private Label labelHoraDispo;
        private Button buttongenerarturno;
        private Button buttoncancelarTurno;
        private ListView listView2;
        private Label labelHistorialturno;
        private Button buttoneditarturno;
    }
}