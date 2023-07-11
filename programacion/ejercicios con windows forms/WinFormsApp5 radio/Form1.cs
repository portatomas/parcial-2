using Microsoft.VisualBasic.Devices;

namespace WinFormsApp5_radio
{
    public partial class Form1 : Form
    {
        private double radio;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var superficie = calcularsuperficie(numero1);
            var perimetro = calcularperimetro(numero1);
            MessageBox.Show($"una circ de radio {radio} tiene un perimetro de {perimetro}, y una superficie {superficie}",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtnumero1.Clear();
            txtnumero1.Focus();
        }

        private object calcularperimetro(int numero1)
        {
            return 2 * radio * Math.PI;
        }

        private object calcularsuperficie(int numero1)
        {
            return Math.PI * Math.Pow(radio, 2);
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