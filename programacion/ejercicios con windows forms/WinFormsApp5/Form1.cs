using Microsoft.VisualBasic.Devices;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private double radio;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuperficie_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var superficie = calcularsuperficie(numero1);
            MessageBox.Show($" tiene una superficie  de  ,{superficie},
             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private object calcularsuperficie(int numero1)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var perimetro = calcularperimetro(numero1);
            MessageBox.Show($" tiene un perimetro de ,{perimetro},
             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private object calcularperimetro(int numero1)
        {
            return 2 * radio * Math.PI;
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
}