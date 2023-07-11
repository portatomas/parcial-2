namespace WinFormsSUMA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var numero2 = int.Parse(txtnumero2.Text);
            // var suma = numero1 + numero2;
            var suma = calcularsuma(numero1, numero2);
            MessageBox.Show($"la suma es {suma}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            inicializarcontroles();

        }

        private void inicializarcontroles()
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtnumero1.Focus();
        }

        private object calcularsuma(int numero1, int numero2) => numero1 + numero2;

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" fin del programa", "salir",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            inicializarcontroles();
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

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}