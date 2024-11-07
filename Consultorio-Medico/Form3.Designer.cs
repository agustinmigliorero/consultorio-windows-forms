namespace Consultorio_Medico
{
    partial class Form3
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
            textBoxnombre = new TextBox();
            textBoxapellido = new TextBox();
            textBoxtel = new TextBox();
            textBoxtelfijo = new TextBox();
            textBoxHisclin = new TextBox();
            textBoxnotas = new TextBox();
            textBoxdni = new TextBox();
            dateTimePickerFechNaci = new DateTimePicker();
            label1 = new Label();
            buttonCrearpaciente = new Button();
            buttonCancelar = new Button();
            btnInvisible = new Button();
            SuspendLayout();

            //Boton invisible
            
            btnInvisible.TabStop = false; // Evitar que el botón reciba el foco a través de la tecla Tab
            btnInvisible.Size = new Size(0, 0); // Hacer el botón invisible
            btnInvisible.Location = new Point(-100, -100); // Ubicar el botón fuera del área visible
            this.Controls.Add(btnInvisible);

            //Boton invisible
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(263, 140);
            textBoxnombre.Margin = new Padding(3, 4, 3, 4);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.PlaceholderText = "Nombre";
            textBoxnombre.Size = new Size(404, 27);
            textBoxnombre.TabIndex = 0;
            textBoxnombre.TextChanged += textBoxnombre_TextChanged;
            // 
            // textBoxapellido
            // 
            textBoxapellido.Location = new Point(263, 179);
            textBoxapellido.Margin = new Padding(3, 4, 3, 4);
            textBoxapellido.Name = "textBoxapellido";
            textBoxapellido.PlaceholderText = "Apellido";
            textBoxapellido.Size = new Size(404, 27);
            textBoxapellido.TabIndex = 1;
            textBoxapellido.TextChanged += textBoxapellido_TextChanged;
            // 
            // textBoxtel
            // 
            textBoxtel.Location = new Point(263, 256);
            textBoxtel.Margin = new Padding(3, 4, 3, 4);
            textBoxtel.Name = "textBoxtel";
            textBoxtel.PlaceholderText = "Telefono";
            textBoxtel.Size = new Size(404, 27);
            textBoxtel.TabIndex = 3;
            textBoxtel.TextChanged += textBoxtel_TextChanged;
            // 
            // textBoxtelfijo
            // 
            textBoxtelfijo.Location = new Point(263, 295);
            textBoxtelfijo.Margin = new Padding(3, 4, 3, 4);
            textBoxtelfijo.Name = "textBoxtelfijo";
            textBoxtelfijo.PlaceholderText = "Telefono Fijo";
            textBoxtelfijo.Size = new Size(404, 27);
            textBoxtelfijo.TabIndex = 4;
            textBoxtelfijo.TextChanged += textBoxtelfijo_TextChanged;
            // 
            // textBoxHisclin
            // 
            textBoxHisclin.Location = new Point(263, 333);
            textBoxHisclin.Margin = new Padding(3, 4, 3, 4);
            textBoxHisclin.Name = "textBoxHisclin";
            textBoxHisclin.PlaceholderText = "Historia Clinica";
            textBoxHisclin.Size = new Size(404, 27);
            textBoxHisclin.TabIndex = 5;
            textBoxHisclin.TextChanged += textBoxHisclin_TextChanged;
            // 
            // textBoxnotas
            // 
            textBoxnotas.Location = new Point(263, 411);
            textBoxnotas.Margin = new Padding(3, 4, 3, 4);
            textBoxnotas.Name = "textBoxnotas";
            textBoxnotas.PlaceholderText = "Notas";
            textBoxnotas.Size = new Size(404, 27);
            textBoxnotas.TabIndex = 7;
            textBoxnotas.TextChanged += textBoxnotas_TextChanged;
            // 
            // textBoxdni
            // 
            textBoxdni.Location = new Point(263, 217);
            textBoxdni.Margin = new Padding(3, 4, 3, 4);
            textBoxdni.Name = "textBoxdni";
            textBoxdni.PlaceholderText = "DNI";
            textBoxdni.Size = new Size(404, 27);
            textBoxdni.TabIndex = 9;
            textBoxdni.TextChanged += textBoxdni_TextChanged;
            // 
            // dateTimePickerFechNaci
            // 
            dateTimePickerFechNaci.Location = new Point(263, 372);
            dateTimePickerFechNaci.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFechNaci.Name = "dateTimePickerFechNaci";
            dateTimePickerFechNaci.Size = new Size(404, 27);
            dateTimePickerFechNaci.TabIndex = 10;
            dateTimePickerFechNaci.ValueChanged += dateTimePickerFechNaci_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 52);
            label1.Name = "label1";
            label1.Size = new Size(232, 34);
            label1.TabIndex = 11;
            label1.Text = "Ingresar Datos";
            // 
            // buttonCrearpaciente
            // 
            buttonCrearpaciente.Location = new Point(311, 496);
            buttonCrearpaciente.Margin = new Padding(3, 4, 3, 4);
            buttonCrearpaciente.Name = "buttonCrearpaciente";
            buttonCrearpaciente.Size = new Size(128, 40);
            buttonCrearpaciente.TabIndex = 12;
            buttonCrearpaciente.Text = "Crear";
            buttonCrearpaciente.UseVisualStyleBackColor = true;
            buttonCrearpaciente.Click += buttonCrearpaciente_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(497, 496);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(128, 41);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonCrearpaciente);
            Controls.Add(label1);
            Controls.Add(dateTimePickerFechNaci);
            Controls.Add(textBoxdni);
            Controls.Add(textBoxnotas);
            Controls.Add(textBoxHisclin);
            Controls.Add(textBoxtelfijo);
            Controls.Add(textBoxtel);
            Controls.Add(textBoxapellido);
            Controls.Add(textBoxnombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxnombre;
        private TextBox textBoxapellido;
        private TextBox textBoxtel;
        private TextBox textBoxtelfijo;
        private TextBox textBoxHisclin;
        private TextBox textBoxnotas;
        private TextBox textBoxdni;
        private DateTimePicker dateTimePickerFechNaci;
        private Label label1;
        private Button buttonCrearpaciente;
        private Button buttonCancelar;
        private Button btnInvisible;
    }
}