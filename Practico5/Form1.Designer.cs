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
            tFoto = new TextBox();
            bAgregar = new Button();
            bFoto = new Button();
            dtpNacimiento = new DateTimePicker();
            rbHombre = new RadioButton();
            rbMujer = new RadioButton();
            tSaldo = new TextBox();
            tApellido = new TextBox();
            lSaldo = new Label();
            lSexo = new Label();
            lNacimiento = new Label();
            lApellido = new Label();
            lNombre = new Label();
            tNombre = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaApellido = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            ColumnaSexo = new DataGridViewTextBoxColumn();
            ColumnaSaldo = new DataGridViewTextBoxColumn();
            ColumnaFoto = new DataGridViewImageColumn();
            ColumnaRuta = new DataGridViewTextBoxColumn();
            ColumnaEliminar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(tFoto);
            panel1.Controls.Add(bAgregar);
            panel1.Controls.Add(bFoto);
            panel1.Controls.Add(dtpNacimiento);
            panel1.Controls.Add(rbHombre);
            panel1.Controls.Add(rbMujer);
            panel1.Controls.Add(tSaldo);
            panel1.Controls.Add(tApellido);
            panel1.Controls.Add(lSaldo);
            panel1.Controls.Add(lSexo);
            panel1.Controls.Add(lNacimiento);
            panel1.Controls.Add(lApellido);
            panel1.Controls.Add(lNombre);
            panel1.Controls.Add(tNombre);
            panel1.Location = new Point(38, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 337);
            panel1.TabIndex = 0;
            // 
            // tFoto
            // 
            tFoto.Location = new Point(200, 221);
            tFoto.Name = "tFoto";
            tFoto.Size = new Size(119, 23);
            tFoto.TabIndex = 13;
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
            bAgregar.Click += bAgregar_Click;
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
            bFoto.Click += bFoto_Click;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(200, 110);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(119, 23);
            dtpNacimiento.TabIndex = 10;
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
            // tSaldo
            // 
            tSaldo.Location = new Point(200, 177);
            tSaldo.Name = "tSaldo";
            tSaldo.Size = new Size(119, 23);
            tSaldo.TabIndex = 7;
            // 
            // tApellido
            // 
            tApellido.Location = new Point(200, 71);
            tApellido.Name = "tApellido";
            tApellido.Size = new Size(119, 23);
            tApellido.TabIndex = 6;
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
            // tNombre
            // 
            tNombre.Location = new Point(200, 36);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(119, 23);
            tNombre.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_08_18_103719;
            pictureBox1.Location = new Point(445, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaNombre, ColumnaApellido, FechaNacimiento, ColumnaSexo, ColumnaSaldo, ColumnaFoto, ColumnaRuta, ColumnaEliminar });
            dataGridView1.Location = new Point(12, 390);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(771, 138);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ColumnaNombre
            // 
            ColumnaNombre.HeaderText = "Nombre";
            ColumnaNombre.Name = "ColumnaNombre";
            // 
            // ColumnaApellido
            // 
            ColumnaApellido.HeaderText = "Apellido";
            ColumnaApellido.Name = "ColumnaApellido";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            // 
            // ColumnaSexo
            // 
            ColumnaSexo.HeaderText = "Sexo";
            ColumnaSexo.Name = "ColumnaSexo";
            // 
            // ColumnaSaldo
            // 
            ColumnaSaldo.HeaderText = "Saldo";
            ColumnaSaldo.Name = "ColumnaSaldo";
            // 
            // ColumnaFoto
            // 
            ColumnaFoto.HeaderText = "Foto";
            ColumnaFoto.Name = "ColumnaFoto";
            // 
            // ColumnaRuta
            // 
            ColumnaRuta.HeaderText = "Ruta";
            ColumnaRuta.Name = "ColumnaRuta";
            // 
            // ColumnaEliminar
            // 
            ColumnaEliminar.HeaderText = "Eliminar";
            ColumnaEliminar.Name = "ColumnaEliminar";
            ColumnaEliminar.Text = "Eliminar";
            ColumnaEliminar.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(795, 591);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.GrayText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Formulario con Grid";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lSaldo;
        private Label lSexo;
        private Label lNacimiento;
        private Label lApellido;
        private Label lNombre;
        private TextBox tNombre;
        private RadioButton rbHombre;
        private RadioButton rbMujer;
        private TextBox tSaldo;
        private TextBox tApellido;
        private DateTimePicker dtpNacimiento;
        private Button bAgregar;
        private Button bFoto;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private TextBox tFoto;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn ColumnaSexo;
        private DataGridViewTextBoxColumn ColumnaSaldo;
        private DataGridViewImageColumn ColumnaFoto;
        private DataGridViewTextBoxColumn ColumnaRuta;
        private DataGridViewButtonColumn ColumnaEliminar;
    }
}
