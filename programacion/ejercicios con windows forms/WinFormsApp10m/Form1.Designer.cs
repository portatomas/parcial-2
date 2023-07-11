namespace WinFormsApp10m
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
            txtfah = new TextBox();
            btnsalir = new Button();
            btncancelar = new Button();
            btnfah = new Button();
            btnreaumur = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 11);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 0;
            label1.Text = "ingrese una temperatura en celsius";
            // 
            // txtfah
            // 
            txtfah.Location = new Point(234, 11);
            txtfah.Name = "txtfah";
            txtfah.Size = new Size(177, 23);
            txtfah.TabIndex = 1;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(713, 314);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 34);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(713, 11);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 38);
            btncancelar.TabIndex = 7;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnfah
            // 
            btnfah.Location = new Point(86, 135);
            btnfah.Name = "btnfah";
            btnfah.Size = new Size(75, 38);
            btnfah.TabIndex = 8;
            btnfah.Text = "fahrenheit";
            btnfah.UseVisualStyleBackColor = true;
            btnfah.Click += btnfah_Click;
            // 
            // btnreaumur
            // 
            btnreaumur.Location = new Point(183, 136);
            btnreaumur.Name = "btnreaumur";
            btnreaumur.Size = new Size(75, 36);
            btnreaumur.TabIndex = 11;
            btnreaumur.Text = "reaumur";
            btnreaumur.UseVisualStyleBackColor = true;
            btnreaumur.Click += btnreaumur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnreaumur);
            Controls.Add(btnfah);
            Controls.Add(btncancelar);
            Controls.Add(btnsalir);
            Controls.Add(txtfah);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtfah;
        private Button btnsalir;
        private Button btncancelar;
        private Button btnfah;
        private Button btnreaumur;
    }
}