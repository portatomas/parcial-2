namespace WinFormsApp24
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
            label2 = new Label();
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            btnresultado = new Button();
            btncancelar = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 7);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "ingrese un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 47);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "ingrese otro numero";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(163, 7);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 2;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(163, 47);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 23);
            txtnumero2.TabIndex = 3;
            // 
            // btnresultado
            // 
            btnresultado.Location = new Point(181, 136);
            btnresultado.Name = "btnresultado";
            btnresultado.Size = new Size(75, 23);
            btnresultado.TabIndex = 4;
            btnresultado.Text = "resultado";
            btnresultado.UseVisualStyleBackColor = true;
            btnresultado.Click += btnresultado_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(704, 21);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(692, 298);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Controls.Add(btncancelar);
            Controls.Add(btnresultado);
            Controls.Add(txtnumero2);
            Controls.Add(txtnumero1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private Button btnresultado;
        private Button btncancelar;
        private Button btnsalir;
    }
}