namespace WinFormsApp7_cotizacion_dolar
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
            label1 = new Label();
            txtnumero2 = new TextBox();
            btndolarof = new Button();
            btndolarparal = new Button();
            btncancelar = new Button();
            btnsalir = new Button();
            label2 = new Label();
            txtnumero1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 53);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "ingrese cotizacion de dolar";
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(177, 45);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 23);
            txtnumero2.TabIndex = 1;
            // 
            // btndolarof
            // 
            btndolarof.Location = new Point(85, 118);
            btndolarof.Name = "btndolarof";
            btndolarof.Size = new Size(86, 28);
            btndolarof.TabIndex = 2;
            btndolarof.Text = "dolar oficial";
            btndolarof.UseVisualStyleBackColor = true;
            btndolarof.Click += Btndolarof_Click;
            // 
            // btndolarparal
            // 
            btndolarparal.Location = new Point(207, 118);
            btndolarparal.Name = "btndolarparal";
            btndolarparal.Size = new Size(100, 28);
            btndolarparal.TabIndex = 3;
            btndolarparal.Text = "dolar paralelo";
            btndolarparal.UseVisualStyleBackColor = true;
            btndolarparal.Click += btndolarparal_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(717, 15);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 4;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(703, 302);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 5;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 6;
            label2.Text = "ingrese pesos a invertir";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(177, 6);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnumero1);
            Controls.Add(label2);
            Controls.Add(btnsalir);
            Controls.Add(btncancelar);
            Controls.Add(btndolarparal);
            Controls.Add(btndolarof);
            Controls.Add(txtnumero2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "cotizacion de dolar";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnumero2;
        private Button btndolarof;
        private Button btndolarparal;
        private Button btncancelar;
        private Button btnsalir;
        private Label label2;
        private TextBox txtnumero1;
    }
}