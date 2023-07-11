namespace WinForms40x
{
    partial class frmopbasicas
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
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            label2 = new Label();
            btnsumar = new Button();
            btnresta = new Button();
            btnmultiplicar = new Button();
            btndivision = new Button();
            btncancelar = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "ingrese un numero";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(134, 9);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(96, 23);
            txtnumero1.TabIndex = 1;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(134, 47);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(96, 23);
            txtnumero2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "ingrese otro numero";
            // 
            // btnsumar
            // 
            btnsumar.Location = new Point(53, 130);
            btnsumar.Name = "btnsumar";
            btnsumar.Size = new Size(75, 35);
            btnsumar.TabIndex = 4;
            btnsumar.Text = "sumar";
            btnsumar.UseVisualStyleBackColor = true;
            btnsumar.Click += btnsumar_Click;
            // 
            // btnresta
            // 
            btnresta.Location = new Point(200, 130);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(75, 34);
            btnresta.TabIndex = 5;
            btnresta.Text = "resta";
            btnresta.UseVisualStyleBackColor = true;
            btnresta.Click += btnresta_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Location = new Point(323, 130);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(75, 35);
            btnmultiplicar.TabIndex = 6;
            btnmultiplicar.Text = "multiplicar";
            btnmultiplicar.UseVisualStyleBackColor = true;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btndivision
            // 
            btndivision.Location = new Point(431, 130);
            btndivision.Name = "btndivision";
            btndivision.Size = new Size(75, 35);
            btndivision.TabIndex = 7;
            btndivision.Text = "division";
            btndivision.UseVisualStyleBackColor = true;
            btndivision.Click += btndivision_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(703, 34);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 34);
            btncancelar.TabIndex = 8;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(716, 310);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 9;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // frmopbasicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Controls.Add(btncancelar);
            Controls.Add(btndivision);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnresta);
            Controls.Add(btnsumar);
            Controls.Add(label2);
            Controls.Add(txtnumero2);
            Controls.Add(txtnumero1);
            Controls.Add(label1);
            Name = "frmopbasicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "operaciones basicas";
            FormClosing += frmopbasicas_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private Label label2;
        private Button btnsumar;
        private Button btnresta;
        private Button btnmultiplicar;
        private Button btndivision;
        private Button btncancelar;
        private Button btnsalir;
    }
}