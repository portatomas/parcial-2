using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp24
{
    public partial class Form1 : Form
    {
        private object Else;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtnumero1.Text);
            var numero2 = int.Parse(txtnumero2.Text);
            if (numero1 % numero2==0)
            {
                MessageBox.Show(" el numero1,es multiplo de numero2 ",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Else
                    {
                    MessageBox.Show("el numero1, no es multiplo de numero2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                
            }
        }
    }
}