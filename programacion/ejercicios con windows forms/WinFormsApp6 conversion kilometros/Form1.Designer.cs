namespace WinFormsApp6_conversion_kilometros
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
            btncancelar = new Button();
            btnmillas = new Button();
            btnyardas = new Button();
            btnsalir = new Button();
            txtnumero1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 16);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "ingrese un num exp en km";
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(713, 12);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnmillas
            // 
            btnmillas.Location = new Point(77, 89);
            btnmillas.Name = "btnmillas";
            btnmillas.Size = new Size(75, 23);
            btnmillas.TabIndex = 2;
            btnmillas.Text = "millas";
            btnmillas.UseVisualStyleBackColor = true;
            btnmillas.Click += btnmillas_Click;
            // 
            // btnyardas
            // 
            btnyardas.Location = new Point(196, 89);
            btnyardas.Name = "btnyardas";
            btnyardas.Size = new Size(75, 23);
            btnyardas.TabIndex = 3;
            btnyardas.Text = "yardas";
            btnyardas.UseVisualStyleBackColor = true;
            btnyardas.Click += btnyardas_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(713, 320);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 4;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(158, 12);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnumero1);
            Controls.Add(btnsalir);
            Controls.Add(btnyardas);
            Controls.Add(btnmillas);
            Controls.Add(btncancelar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btncancelar;
        private Button btnmillas;
        private Button btnyardas;
        private Button btnsalir;
        private TextBox txtnumero1;
    }
}