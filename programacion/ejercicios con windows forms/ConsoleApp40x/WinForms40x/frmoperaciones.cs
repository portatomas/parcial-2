namespace WinForms40x
{
    public partial class frmopbasicas : Form
    {
        public frmopbasicas()
        {
            InitializeComponent();
        }
        operacion operacionseleccionada;
        
        private void btnsumar_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var numero2 = int.Parse(txtnumero2.Text);
            // var suma = numero1 + numero2;
            var suma = calcularsuma(numero1, numero2);
            MessageBox.Show($"la suma es {suma}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            inicializarcontroles();
        }
      
        
        private int calcularsuma(int numero1, int numero2) => numero1 + numero2;
        private int calcularresta(int numero1, int numero2) => numero1 - numero2;
        private int calcularmultiplicacion(int numero1, int numero2) => numero1 * numero2;
        private int calculardivision(int numero1, int numero2) => numero1 / numero2;

        private void inicializarcontroles()
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtnumero1.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            inicializarcontroles();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {

            var numero1 = int.Parse(txtnumero1.Text);
            var numero2 = int.Parse(txtnumero2.Text);
            var resta = calcularresta(numero1, numero2);
            MessageBox.Show($"la resta es {resta}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            inicializarcontroles();


        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var numero2 = int.Parse(txtnumero2.Text);
            var multiplicacion = calcularmultiplicacion(numero1, numero2);

            MessageBox.Show($"la multiplicacion es {multiplicacion}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            inicializarcontroles();

        }

        private void btndivision_Click(object sender, EventArgs e)
        {

            var numero1 = int.Parse(txtnumero1.Text);
            var numero2 = int.Parse(txtnumero2.Text);
            var division = calculardivision(numero1, numero2);
            MessageBox.Show($"la division es {division}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            inicializarcontroles();
        }

        private void frmopbasicas_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" fin del programa", "salir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            Application.Exit();
        }
    }
}