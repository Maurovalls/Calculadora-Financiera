namespace CalculadoraFinancieraLaboratio2020
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
            this.operacionesBasicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesCompuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentoSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentoCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amortizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesBasicasToolStripMenuItem,
            this.interesSimpleToolStripMenuItem,
            this.interesCompuestoToolStripMenuItem,
            this.descuentoSimpleToolStripMenuItem,
            this.descuentoCompletoToolStripMenuItem,
            this.amortizacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesBasicasToolStripMenuItem
            // 
            this.operacionesBasicasToolStripMenuItem.Name = "operacionesBasicasToolStripMenuItem";
            this.operacionesBasicasToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.operacionesBasicasToolStripMenuItem.Text = "Operaciones Basicas";
            this.operacionesBasicasToolStripMenuItem.Click += new System.EventHandler(this.operacionesBasicasToolStripMenuItem_Click);
            // 
            // interesSimpleToolStripMenuItem
            // 
            this.interesSimpleToolStripMenuItem.Name = "interesSimpleToolStripMenuItem";
            this.interesSimpleToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.interesSimpleToolStripMenuItem.Text = "Interes Simple";
            this.interesSimpleToolStripMenuItem.Click += new System.EventHandler(this.interesSimpleToolStripMenuItem_Click);
            // 
            // interesCompuestoToolStripMenuItem
            // 
            this.interesCompuestoToolStripMenuItem.Name = "interesCompuestoToolStripMenuItem";
            this.interesCompuestoToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.interesCompuestoToolStripMenuItem.Text = "Interes Compuesto";
            this.interesCompuestoToolStripMenuItem.Click += new System.EventHandler(this.interesCompuestoToolStripMenuItem_Click);
            // 
            // descuentoSimpleToolStripMenuItem
            // 
            this.descuentoSimpleToolStripMenuItem.Name = "descuentoSimpleToolStripMenuItem";
            this.descuentoSimpleToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.descuentoSimpleToolStripMenuItem.Text = "Descuento Simple";
            this.descuentoSimpleToolStripMenuItem.Click += new System.EventHandler(this.descuentoSimpleToolStripMenuItem_Click);
            // 
            // descuentoCompletoToolStripMenuItem
            // 
            this.descuentoCompletoToolStripMenuItem.Name = "descuentoCompletoToolStripMenuItem";
            this.descuentoCompletoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.descuentoCompletoToolStripMenuItem.Text = " Monto Final";
            this.descuentoCompletoToolStripMenuItem.Click += new System.EventHandler(this.descuentoCompletoToolStripMenuItem_Click);
            // 
            // amortizacionToolStripMenuItem
            // 
            this.amortizacionToolStripMenuItem.Name = "amortizacionToolStripMenuItem";
            this.amortizacionToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.amortizacionToolStripMenuItem.Text = "¿Cuanto Depositar?";
            this.amortizacionToolStripMenuItem.Click += new System.EventHandler(this.amortizacionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CalculadoraFinancieraLaboratio2020.Properties.Resources.imgFina;
            this.ClientSize = new System.Drawing.Size(680, 377);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculadora Financiera";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesBasicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interesSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interesCompuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentoSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentoCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amortizacionToolStripMenuItem;
    }
}

