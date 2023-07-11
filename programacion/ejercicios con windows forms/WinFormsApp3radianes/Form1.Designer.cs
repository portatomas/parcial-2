namespace WinFormsApp3radianes
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
            btnradianes = new Button();
            btncancelar = new Button();
            btnsalir = new Button();
            txtnumero1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(222, 15);
            label1.TabIndex = 0;
            label1.Text = "ingrese un numero a convertir a radianes";
            // 
            // btnradianes
            // 
            btnradianes.Location = new Point(64, 92);
            btnradianes.Name = "btnradianes";
            btnradianes.Size = new Size(75, 29);
            btnradianes.TabIndex = 1;
            btnradianes.Text = "conversion ";
            btnradianes.UseVisualStyleBackColor = true;
            btnradianes.Click += btnradianes_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(713, 26);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 2;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(723, 321);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 22);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(261, 5);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnumero1);
            Controls.Add(btnsalir);
            Controls.Add(btncancelar);
            Controls.Add(btnradianes);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnradianes;
        private Button btncancelar;
        private Button btnsalir;
        private TextBox txtnumero1;
    }
}