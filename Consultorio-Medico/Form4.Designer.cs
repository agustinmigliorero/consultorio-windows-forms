namespace Consultorio_Medico
{
    partial class Form4
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
            buttonCancelar = new Button();
            buttonEditarpaciente = new Button();
            label1 = new Label();
            dateTimePickerFechNaci = new DateTimePicker();
            textBoxdni = new TextBox();
            textBoxnotas = new TextBox();
            textBoxHisclin = new TextBox();
            textBoxtelfijo = new TextBox();
            textBoxtel = new TextBox();
            textBoxapellido = new TextBox();
            textBoxnombre = new TextBox();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(428, 376);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(112, 31);
            buttonCancelar.TabIndex = 24;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonEditarpaciente
            // 
            buttonEditarpaciente.Location = new Point(265, 376);
            buttonEditarpaciente.Name = "buttonEditarpaciente";
            buttonEditarpaciente.Size = new Size(112, 30);
            buttonEditarpaciente.TabIndex = 23;
            buttonEditarpaciente.Text = "Editar";
            buttonEditarpaciente.UseVisualStyleBackColor = true;
            buttonEditarpaciente.Click += buttonEditarpaciente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 43);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 22;
            label1.Text = "Ingresar Datos";
            // 
            // dateTimePickerFechNaci
            // 
            dateTimePickerFechNaci.Location = new Point(223, 283);
            dateTimePickerFechNaci.Name = "dateTimePickerFechNaci";
            dateTimePickerFechNaci.Size = new Size(354, 23);
            dateTimePickerFechNaci.TabIndex = 21;
            // 
            // textBoxdni
            // 
            textBoxdni.Location = new Point(223, 167);
            textBoxdni.Name = "textBoxdni";
            textBoxdni.PlaceholderText = "DNI";
            textBoxdni.Size = new Size(354, 23);
            textBoxdni.TabIndex = 20;
            // 
            // textBoxnotas
            // 
            textBoxnotas.Location = new Point(223, 312);
            textBoxnotas.Name = "textBoxnotas";
            textBoxnotas.PlaceholderText = "Notas";
            textBoxnotas.Size = new Size(354, 23);
            textBoxnotas.TabIndex = 19;
            // 
            // textBoxHisclin
            // 
            textBoxHisclin.Location = new Point(223, 254);
            textBoxHisclin.Name = "textBoxHisclin";
            textBoxHisclin.PlaceholderText = "Historia Clinica";
            textBoxHisclin.Size = new Size(354, 23);
            textBoxHisclin.TabIndex = 18;
            // 
            // textBoxtelfijo
            // 
            textBoxtelfijo.Location = new Point(223, 225);
            textBoxtelfijo.Name = "textBoxtelfijo";
            textBoxtelfijo.PlaceholderText = "Telefono Fijo";
            textBoxtelfijo.Size = new Size(354, 23);
            textBoxtelfijo.TabIndex = 17;
            // 
            // textBoxtel
            // 
            textBoxtel.Location = new Point(223, 196);
            textBoxtel.Name = "textBoxtel";
            textBoxtel.PlaceholderText = "Telefono";
            textBoxtel.Size = new Size(354, 23);
            textBoxtel.TabIndex = 16;
            // 
            // textBoxapellido
            // 
            textBoxapellido.Location = new Point(223, 138);
            textBoxapellido.Name = "textBoxapellido";
            textBoxapellido.PlaceholderText = "Apellido";
            textBoxapellido.Size = new Size(354, 23);
            textBoxapellido.TabIndex = 15;
            textBoxapellido.TextChanged += textBoxapellido_TextChanged;
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(223, 109);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.PlaceholderText = "Nombre";
            textBoxnombre.Size = new Size(354, 23);
            textBoxnombre.TabIndex = 14;
            textBoxnombre.TextChanged += textBoxnombre_TextChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEditarpaciente);
            Controls.Add(label1);
            Controls.Add(dateTimePickerFechNaci);
            Controls.Add(textBoxdni);
            Controls.Add(textBoxnotas);
            Controls.Add(textBoxHisclin);
            Controls.Add(textBoxtelfijo);
            Controls.Add(textBoxtel);
            Controls.Add(textBoxapellido);
            Controls.Add(textBoxnombre);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonEditarpaciente;
        private Label label1;
        private DateTimePicker dateTimePickerFechNaci;
        private TextBox textBoxdni;
        private TextBox textBoxnotas;
        private TextBox textBoxHisclin;
        private TextBox textBoxtelfijo;
        private TextBox textBoxtel;
        private TextBox textBoxapellido;
        private TextBox textBoxnombre;
    }
}