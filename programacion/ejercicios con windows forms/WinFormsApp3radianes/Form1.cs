namespace WinFormsApp3radianes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnradianes_Click(object sender, EventArgs e)
        {

            var numero1 = int.Parse(txtnumero1.Text);
            var conversion = conversionradianes(numero1);
            MessageBox.Show($"la conversion a radianes es {conversion}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtnumero1.Clear();
            txtnumero1.Focus();

        }

        private object conversionradianes(int numero1)
        {
            return numero1 * 0.0174532925;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" fin del programa", "salir",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
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
    }
}