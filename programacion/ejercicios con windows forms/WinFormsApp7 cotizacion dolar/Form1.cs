namespace WinFormsApp7_cotizacion_dolar
{
    public partial class Form1 : Form
    {
        private int sumaenpesos;
        private int cotizacionendolaroficial;
        private int cotizacionendolarparalelo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btndolarof_Click(object sender, EventArgs e)
        {
            var sumaenpesos = int.Parse(txtnumero1.Text);
            var numero1 = int.Parse(txtnumero2.Text);
            var dolarof = calcularsumadolarof(numero1);
            DialogResult dialogResult = MessageBox.Show($"equivalen a ", sumaenpesos / cotizacionendolaroficial);
            MessageBoxButtons oK = MessageBoxButtons.OK; MessageBoxIcon information = MessageBoxIcon.Information;
            txtnumero2.Clear();

        }

        private object calcularsumadolarof(int numero1)
        {
            return sumaenpesos / cotizacionendolaroficial;
        }

        private void btndolarparal_Click(object sender, EventArgs e)
            
        {
            var sumaenpesos = int.Parse(txtnumero1.Text);
            var numero1 = int.Parse(txtnumero2.Text);
            var dolarparal = calcularsumadolarparal(numero1);
            DialogResult dialogResult = MessageBox.Show($"equivalen a ", sumaenpesos/cotizacionendolarparalelo);
            MessageBoxButtons oK = MessageBoxButtons.OK; MessageBoxIcon information = MessageBoxIcon.Information;
            txtnumero2.Clear();
        }

        private object calcularsumadolarparal(int numero1)
        {
            return sumaenpesos / cotizacionendolarparalelo;
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
            txtnumero2.Clear();
            txtnumero1.Focus();
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