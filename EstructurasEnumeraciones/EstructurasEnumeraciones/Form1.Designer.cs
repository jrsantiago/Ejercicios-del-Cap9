namespace EstructurasEnumeraciones
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoDeTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuenaBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.neumaticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoDeTiendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoDeTiendaToolStripMenuItem
            // 
            this.productoDeTiendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuenaBancariaToolStripMenuItem,
            this.cuentaBancariaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.neumaticosToolStripMenuItem,
            this.toolStripMenuItem3});
            this.productoDeTiendaToolStripMenuItem.Name = "productoDeTiendaToolStripMenuItem";
            this.productoDeTiendaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productoDeTiendaToolStripMenuItem.Text = "Explorar";
            this.productoDeTiendaToolStripMenuItem.Click += new System.EventHandler(this.productoDeTiendaToolStripMenuItem_Click);
            // 
            // cuenaBancariaToolStripMenuItem
            // 
            this.cuenaBancariaToolStripMenuItem.Name = "cuenaBancariaToolStripMenuItem";
            this.cuenaBancariaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cuenaBancariaToolStripMenuItem.Text = "1.Producto de Tienda";
            this.cuenaBancariaToolStripMenuItem.Click += new System.EventHandler(this.cuenaBancariaToolStripMenuItem_Click);
            // 
            // cuentaBancariaToolStripMenuItem
            // 
            this.cuentaBancariaToolStripMenuItem.Name = "cuentaBancariaToolStripMenuItem";
            this.cuentaBancariaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cuentaBancariaToolStripMenuItem.Text = "2.Cuenta Bancaria";
            this.cuentaBancariaToolStripMenuItem.Click += new System.EventHandler(this.cuentaBancariaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem2.Text = "3.Mascota y Dueno";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // neumaticosToolStripMenuItem
            // 
            this.neumaticosToolStripMenuItem.Name = "neumaticosToolStripMenuItem";
            this.neumaticosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.neumaticosToolStripMenuItem.Text = "4.Neumaticos";
            this.neumaticosToolStripMenuItem.Click += new System.EventHandler(this.neumaticosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem3.Text = "5.Tipo de Estrellas";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoDeTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuenaBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem neumaticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

