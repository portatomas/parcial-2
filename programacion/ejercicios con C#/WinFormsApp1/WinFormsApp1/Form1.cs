namespace WinFormsApp1
{
    public partial class F : Form
    {
        public FrmOpbasicas()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            var numero1=int.Parse(txtnumero1.Text);
            var numero2=int.Parse(txtnumero2.Text); 
            var suma= numero1 + numero2;
            _ = MessageBox.Show($"la suma es {suma}", "resultado",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            
                
        }
    }
}