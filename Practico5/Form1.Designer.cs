namespace Practico5
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            lNombre = new Label();
            lApellido = new Label();
            lNacimiento = new Label();
            lSexo = new Label();
            lSaldo = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            rbMujer = new RadioButton();
            rbHombre = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            bFoto = new Button();
            bAgregar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(bAgregar);
            panel1.Controls.Add(bFoto);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(rbHombre);
            panel1.Controls.Add(rbMujer);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(lSaldo);
            panel1.Controls.Add(lSexo);
            panel1.Controls.Add(lNacimiento);
            panel1.Controls.Add(lApellido);
            panel1.Controls.Add(lNombre);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(38, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 337);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 0;
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombre.ForeColor = SystemColors.Window;
            lNombre.Location = new Point(18, 29);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(88, 33);
            lNombre.TabIndex = 1;
            lNombre.Text = "Nombre";
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lApellido.ForeColor = SystemColors.Window;
            lApellido.Location = new Point(18, 64);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(94, 33);
            lApellido.TabIndex = 2;
            lApellido.Text = "Apellido";
            // 
            // lNacimiento
            // 
            lNacimiento.AutoSize = true;
            lNacimiento.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNacimiento.ForeColor = SystemColors.Window;
            lNacimiento.Location = new Point(18, 106);
            lNacimiento.Name = "lNacimiento";
            lNacimiento.Size = new Size(180, 33);
            lNacimiento.TabIndex = 3;
            lNacimiento.Text = "Fecha Nacimiento";
            // 
            // lSexo
            // 
            lSexo.AutoSize = true;
            lSexo.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSexo.ForeColor = SystemColors.Window;
            lSexo.Location = new Point(18, 134);
            lSexo.Name = "lSexo";
            lSexo.Size = new Size(66, 33);
            lSexo.TabIndex = 4;
            lSexo.Text = "Sexo";
            // 
            // lSaldo
            // 
            lSaldo.AutoSize = true;
            lSaldo.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSaldo.ForeColor = SystemColors.Window;
            lSaldo.Location = new Point(15, 170);
            lSaldo.Name = "lSaldo";
            lSaldo.Size = new Size(74, 33);
            lSaldo.TabIndex = 5;
            lSaldo.Text = "Saldo";
            lSaldo.Click += lSaldo_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(119, 23);
            textBox3.TabIndex = 7;
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.ForeColor = SystemColors.Window;
            rbMujer.Location = new Point(200, 142);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(56, 19);
            rbMujer.TabIndex = 8;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.ForeColor = SystemColors.Window;
            rbHombre.Location = new Point(280, 142);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(69, 19);
            rbHombre.TabIndex = 9;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(200, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(119, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.mujer;
            pictureBox1.Location = new Point(445, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // bFoto
            // 
            bFoto.ForeColor = SystemColors.ControlText;
            bFoto.Location = new Point(18, 221);
            bFoto.Name = "bFoto";
            bFoto.Size = new Size(75, 23);
            bFoto.TabIndex = 11;
            bFoto.Text = "Foto";
            bFoto.UseVisualStyleBackColor = true;
            // 
            // bAgregar
            // 
            bAgregar.ForeColor = SystemColors.Desktop;
            bAgregar.Image = Properties.Resources.Captura_de_pantalla_2025;
            bAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            bAgregar.Location = new Point(93, 263);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(149, 61);
            bAgregar.TabIndex = 12;
            bAgregar.Text = "Agregar";
            bAgregar.TextAlign = ContentAlignment.MiddleRight;
            bAgregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(799, 531);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.GrayText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Formulario con Grid";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lSaldo;
        private Label lSexo;
        private Label lNacimiento;
        private Label lApellido;
        private Label lNombre;
        private TextBox textBox1;
        private RadioButton rbHombre;
        private RadioButton rbMujer;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button bAgregar;
        private Button bFoto;
        private PictureBox pictureBox1;
    }
}
