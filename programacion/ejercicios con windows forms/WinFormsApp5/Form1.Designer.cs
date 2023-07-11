namespace WinFormsApp5
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
            btnsuperficie = new Button();
            btncancelar = new Button();
            btnsalir = new Button();
            btnperimetro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "ingrese un nro de radio";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(159, 13);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 1;
            // 
            // btnsuperficie
            // 
            btnsuperficie.Location = new Point(24, 84);
            btnsuperficie.Name = "btnsuperficie";
            btnsuperficie.Size = new Size(75, 23);
            btnsuperficie.TabIndex = 2;
            btnsuperficie.Text = "superficie";
            btnsuperficie.UseVisualStyleBackColor = true;
            btnsuperficie.Click += btnsuperficie_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(713, 27);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(713, 315);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 4;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnperimetro
            // 
            btnperimetro.Location = new Point(157, 84);
            btnperimetro.Name = "btnperimetro";
            btnperimetro.Size = new Size(75, 23);
            btnperimetro.TabIndex = 5;
            btnperimetro.Text = "perimetro";
            btnperimetro.UseVisualStyleBackColor = true;
            btnperimetro.Click += btnperimetro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnperimetro);
            Controls.Add(btnsalir);
            Controls.Add(btncancelar);
            Controls.Add(btnsuperficie);
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
        private Button btnsuperficie;
        private Button btncancelar;
        private Button btnsalir;
        private Button btnperimetro;
    }
}