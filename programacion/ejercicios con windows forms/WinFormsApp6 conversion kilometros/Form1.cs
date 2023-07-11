namespace WinFormsApp6_conversion_kilometros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmillas_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var millas = calcularmillas(numero1);
            MessageBox.Show($"su equivalente en millas es {millas}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private object calcularmillas(int numero1)
        {
            return numero1 * 0.621371192;
        }

        private void btnyardas_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var yardas = calcularyardas(numero1);
            MessageBox.Show($"su equivalente en yardas es  {yardas}", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtnumero1.Clear();
            txtnumero1.Focus();
        }

        private object calcularyardas(int numero1)
        {
            return numero1 * 1093.61;
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