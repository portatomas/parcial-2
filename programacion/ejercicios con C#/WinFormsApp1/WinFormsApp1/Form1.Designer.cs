namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnsuma = new Button();
            btnsalir = new Button();
            btncancelar = new Button();
            btnresta = new Button();
            btndivision = new Button();
            btnmultiplicar = new Button();
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "ingrese un numero";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(133, 8);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 2;
            // 
            // label
            // 
            label1.Location = new Point(133, 37);
            label1.Name = "label";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 3;
            // 
            // ingre
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "ingre";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "ingrese otro numero";
            // 
            // btnsuma
            // 
            btnsuma.Location = new Point(30, 122);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(75, 49);
            btnsuma.TabIndex = 4;
            btnsuma.Text = "sumar";
            btnsuma.UseVisualStyleBackColor = true;
            btnsuma.Click += btnsuma_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(487, 301);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(109, 41);
            btnsalir.TabIndex = 5;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(367, 15);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 45);
            btncancelar.TabIndex = 8;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnresta
            // 
            btnresta.Location = new Point(123, 121);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(75, 49);
            btnresta.TabIndex = 5;
            btnresta.Text = "resta";
            btnresta.UseVisualStyleBackColor = true;
            // 
            // btndivision
            // 
            btndivision.Location = new Point(219, 119);
            btndivision.Name = "btndivision";
            btndivision.Size = new Size(75, 49);
            btndivision.TabIndex = 6;
            btndivision.Text = "division";
            btndivision.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Location = new Point(319, 122);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(75, 46);
            btnmultiplicar.TabIndex = 7;
            btnmultiplicar.Text = "multiplicar";
            btnmultiplicar.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            

        #endregion

        private Label label1;
        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private Label label2;
        private Button btnsuma;
        private Button btnsalir;
        private Button btncancelar;
        private Button btnresta;
        private Button btndivision;
        private Button btnmultiplicar;

        public EventHandler btnsuma_Click { get; private set; }
    }
}