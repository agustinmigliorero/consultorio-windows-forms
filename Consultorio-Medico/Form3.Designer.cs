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
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(230, 105);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.PlaceholderText = "Nombre";
            textBoxnombre.Size = new Size(354, 23);
            textBoxnombre.TabIndex = 0;
            textBoxnombre.TextChanged += textBoxnombre_TextChanged;
            // 
            // textBoxapellido
            // 
            textBoxapellido.Location = new Point(230, 134);
            textBoxapellido.Name = "textBoxapellido";
            textBoxapellido.PlaceholderText = "Apellido";
            textBoxapellido.Size = new Size(354, 23);
            textBoxapellido.TabIndex = 1;
            textBoxapellido.TextChanged += textBoxapellido_TextChanged;
            // 
            // textBoxtel
            // 
            textBoxtel.Location = new Point(230, 192);
            textBoxtel.Name = "textBoxtel";
            textBoxtel.PlaceholderText = "Telefono";
            textBoxtel.Size = new Size(354, 23);
            textBoxtel.TabIndex = 3;
            textBoxtel.TextChanged += textBoxtel_TextChanged;
            // 
            // textBoxtelfijo
            // 
            textBoxtelfijo.Location = new Point(230, 221);
            textBoxtelfijo.Name = "textBoxtelfijo";
            textBoxtelfijo.PlaceholderText = "Telefono Fijo";
            textBoxtelfijo.Size = new Size(354, 23);
            textBoxtelfijo.TabIndex = 4;
            textBoxtelfijo.TextChanged += textBoxtelfijo_TextChanged;
            // 
            // textBoxHisclin
            // 
            textBoxHisclin.Location = new Point(230, 250);
            textBoxHisclin.Name = "textBoxHisclin";
            textBoxHisclin.PlaceholderText = "Historia Clinica";
            textBoxHisclin.Size = new Size(354, 23);
            textBoxHisclin.TabIndex = 5;
            textBoxHisclin.TextChanged += textBoxHisclin_TextChanged;
            // 
            // textBoxnotas
            // 
            textBoxnotas.Location = new Point(230, 308);
            textBoxnotas.Name = "textBoxnotas";
            textBoxnotas.PlaceholderText = "Notas";
            textBoxnotas.Size = new Size(354, 23);
            textBoxnotas.TabIndex = 7;
            textBoxnotas.TextChanged += textBoxnotas_TextChanged;
            // 
            // textBoxdni
            // 
            textBoxdni.Location = new Point(230, 163);
            textBoxdni.Name = "textBoxdni";
            textBoxdni.PlaceholderText = "DNI";
            textBoxdni.Size = new Size(354, 23);
            textBoxdni.TabIndex = 9;
            textBoxdni.TextChanged += textBoxdni_TextChanged;
            // 
            // dateTimePickerFechNaci
            // 
            dateTimePickerFechNaci.Location = new Point(230, 279);
            dateTimePickerFechNaci.Name = "dateTimePickerFechNaci";
            dateTimePickerFechNaci.Size = new Size(354, 23);
            dateTimePickerFechNaci.TabIndex = 10;
            dateTimePickerFechNaci.ValueChanged += dateTimePickerFechNaci_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 39);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 11;
            label1.Text = "Ingresar Datos";
            // 
            // buttonCrearpaciente
            // 
            buttonCrearpaciente.BackColor = Color.Plum;
            buttonCrearpaciente.Location = new Point(272, 372);
            buttonCrearpaciente.Name = "buttonCrearpaciente";
            buttonCrearpaciente.Size = new Size(112, 30);
            buttonCrearpaciente.TabIndex = 12;
            buttonCrearpaciente.Text = "Crear";
            buttonCrearpaciente.UseVisualStyleBackColor = false;
            buttonCrearpaciente.Click += buttonCrearpaciente_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Salmon;
            buttonCancelar.Location = new Point(435, 372);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(112, 31);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // btnInvisible
            // 
            btnInvisible.Location = new Point(-88, -75);
            btnInvisible.Margin = new Padding(3, 2, 3, 2);
            btnInvisible.Name = "btnInvisible";
            btnInvisible.Size = new Size(0, 0);
            btnInvisible.TabIndex = 0;
            btnInvisible.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvisible);
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