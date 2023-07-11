namespace ejercicio8form
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
            btnnroentero = new Button();
            btnsalir = new Button();
            txtnumero1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "ingresar un numero";
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(713, 12);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnnroentero
            // 
            btnnroentero.Location = new Point(151, 67);
            btnnroentero.Name = "btnnroentero";
            btnnroentero.Size = new Size(113, 33);
            btnnroentero.TabIndex = 2;
            btnnroentero.Text = "numero entero";
            btnnroentero.UseVisualStyleBackColor = true;
            btnnroentero.Click += btnnroentero_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(699, 419);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(164, 10);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(699, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 450);
            Controls.Add(button1);
            Controls.Add(txtnumero1);
            Controls.Add(btnsalir);
            Controls.Add(btnnroentero);
            Controls.Add(btncancelar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "numero entero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btncancelar;
        private Button btnnroentero;
        private Button btnsalir;
        private TextBox txtnumero1;
        private Button button1;
    }
}