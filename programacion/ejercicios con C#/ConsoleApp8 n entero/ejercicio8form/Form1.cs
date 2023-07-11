using Microsoft.VisualBasic.Devices;

namespace ejercicio8form
{
    public partial class Form1 : Form
    {
        private int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnnroentero_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var numeroentero = devolvernumeroentero(numero1);

            MessageBox.Show($" el numero entero es " { n}
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtnumero1.Clear();
            txtnumero1.Focus();
        }

        private object devolvernumeroentero(int numero1)
        {
            return n = (n * (n + 1)) / 2;
        }
    }
}