namespace EstructurasEnumeraciones
{
    partial class CuentaBancaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.cuentaEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AhorrosBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorrienteBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreditostextBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Cliente";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(97, 9);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox.TabIndex = 1;
            // 
            // cuentaEnter
            // 
            this.cuentaEnter.Location = new System.Drawing.Point(191, 47);
            this.cuentaEnter.Name = "cuentaEnter";
            this.cuentaEnter.Size = new System.Drawing.Size(69, 27);
            this.cuentaEnter.TabIndex = 2;
            this.cuentaEnter.Text = "Entrar";
            this.cuentaEnter.UseVisualStyleBackColor = true;
            this.cuentaEnter.Click += new System.EventHandler(this.cuentaEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "add ahorro";
            // 
            // AhorrosBox1
            // 
            this.AhorrosBox1.Location = new System.Drawing.Point(97, 44);
            this.AhorrosBox1.Name = "AhorrosBox1";
            this.AhorrosBox1.Size = new System.Drawing.Size(71, 20);
            this.AhorrosBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "add Corriente";
            // 
            // CorrienteBox2
            // 
            this.CorrienteBox2.Location = new System.Drawing.Point(97, 87);
            this.CorrienteBox2.Name = "CorrienteBox2";
            this.CorrienteBox2.Size = new System.Drawing.Size(71, 20);
            this.CorrienteBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "add Credito";
            // 
            // CreditostextBox3
            // 
            this.CreditostextBox3.Location = new System.Drawing.Point(97, 135);
            this.CreditostextBox3.Name = "CreditostextBox3";
            this.CreditostextBox3.Size = new System.Drawing.Size(87, 20);
            this.CreditostextBox3.TabIndex = 8;
            // 
            // CuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CreditostextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CorrienteBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AhorrosBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuentaEnter);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label1);
            this.Name = "CuentaBancaria";
            this.Text = "CuentaBancaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button cuentaEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AhorrosBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorrienteBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreditostextBox3;
    }
}