namespace WinFormsSUMA1
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
            txtnumero1 = new TextBox();
            label2 = new Label();
            txtnumero2 = new TextBox();
            btnsuma = new Button();
            btnsalir = new Button();
            btncancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 0;
            label1.Text = "INGRESE UN NUMERO A SUMAR";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(220, 9);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 1;
            txtnumero1.TextChanged += txtnumero1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 39);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 2;
            label2.Text = "INGRESE OTRO NUMERO A SUMAR";
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(220, 39);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 23);
            txtnumero2.TabIndex = 3;
            // 
            // btnsuma
            // 
            btnsuma.Location = new Point(116, 131);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(75, 29);
            btnsuma.TabIndex = 4;
            btnsuma.Text = "SUMAR";
            btnsuma.UseVisualStyleBackColor = true;
            btnsuma.Click += btnsuma_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(713, 321);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 32);
            btnsalir.TabIndex = 5;
            btnsalir.Text = "SALIR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(713, 22);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 32);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncancelar);
            Controls.Add(btnsalir);
            Controls.Add(btnsuma);
            Controls.Add(txtnumero2);
            Controls.Add(label2);
            Controls.Add(txtnumero1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnumero1;
        private Label label2;
        private TextBox txtnumero2;
        private Button btnsuma;
        private Button btnsalir;
        private Button btncancelar;
    }
}