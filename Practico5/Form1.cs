namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //obtiene la ruta del archivo
                    string rutaArchivo = openFileDialog1.FileName;
                    //muestra la imagen en el pictureBox
                    pictureBox1.Image = Image.FromFile(rutaArchivo);
                    //muestra la ruta en el textbox
                    tFoto.Text = rutaArchivo;
                }
                catch (Exception ex)
                {
                    //muestra el erro al cargar la imagen
                    MessageBox.Show("Error al cargar la imagen" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tNombre.Text) || string.IsNullOrWhiteSpace(tApellido.Text))
            {
                MessageBox.Show("Los campos nombre y apellido no deben estar vacíos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validar saldo
            decimal saldo;
            if (!decimal.TryParse(tSaldo.Text, out saldo))
            {
                MessageBox.Show("El saldo debe ser un valor numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //determinar el sexo seleccionado
            string sexoSeleccionado = " ";
            if (rbHombre.Checked)
            {
                sexoSeleccionado = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                sexoSeleccionado = "Mujer";
            }

            //formatea el nombre y apellido
            string nombreFormateado = tNombre.Text.Substring(0, 1).ToUpper() + tNombre.Text.Substring(1).ToLower();
            string apellidoFormateado = tApellido.Text.Substring(0, 1).ToUpper() + tApellido.Text.Substring(1).ToLower();

            //crear un array de objetos con los datos del usuario
            object[] fila =
            {
                nombreFormateado,
                apellidoFormateado,
                dtpNacimiento.Value.ToShortDateString(),
                sexoSeleccionado,
                saldo,
                pictureBox1.Image,
                tFoto.Text,
            };

            //agrega la fila al datagridview
            int rowIndex = dataGridView1.Rows.Add(fila);

            //cambiar el color de fondo de la fila segun el saldo
            if(saldo < 50)
            {
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

            //limpiar los campos
            tNombre.Clear();
            tApellido.Clear();
            tSaldo.Clear();
            tFoto.Clear();
            string rutaImagenDefecto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos", "avatar.png");
            if (File.Exists(rutaImagenDefecto))
            {
                pictureBox1.Image = Image.FromFile(rutaImagenDefecto);
            }
            dtpNacimiento.Value = DateTime.Now;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // configura el formato de la columna nombre y apellido
            dataGridView1.Columns["ColumnaNombre"].DefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            dataGridView1.Columns["ColumnaApellido"].DefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Italic);

            string rutaImagenDefecto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos", "avatar.png");
            if (File.Exists(rutaImagenDefecto))
            {
                pictureBox1.Image = Image.FromFile(rutaImagenDefecto);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica que se haya hecho click en una fila válida
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ColumnaEliminar"].Index)
            {
                //mensaje de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resultado == DialogResult.Yes)
                {
                    //elimina la fila seleccionada
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
