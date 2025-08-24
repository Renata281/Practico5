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
            if (!string.IsNullOrEmpty(tNombre.Text))
            {
                string nombreFormateado = tNombre.Text.Substring(0, 1).ToUpper() + tNombre.Text.Substring(1).ToLower();
                tNombre.Text = nombreFormateado;
            }

            if (!string.IsNullOrEmpty(tApellido.Text))
            {
                string apellidoFormateado = tApellido.Text.Substring(0, 1).ToUpper() + tApellido.Text.Substring(1).ToLower();
                tApellido.Text = apellidoFormateado;
            }
        }
    }
}
