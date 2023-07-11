namespace WinFormsApp10m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnfah_Click(object sender, EventArgs e)
        {
            var celsius = int.Parse(txtfah.Text);
            var fah = 1.8 * celsius + 32;
            MessageBox.Show($"celsius equivale a {fah}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnreaumur_Click(object sender, EventArgs e)
        {
            var celsius = int.Parse(txtfah.Text);
            var reaumur = 0.8 * celsius;
            MessageBox.Show($" celsius equivale a {reaumur}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void inicializarcontroles()
        {
            txtfah.Clear();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" fin del programa", "salir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            Application.Exit();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿desea salir del formulario?",
               "pregunta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;// cancela el evento de cierre del form
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            inicializarcontroles
        }
    }
}
