namespace CalculadoraFinancieraLaboratio2020
{
    partial class InteresSimple
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.textTaza = new System.Windows.Forms.TextBox();
            this.textTiempo = new System.Windows.Forms.TextBox();
            this.comboTiempo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboTaza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(73, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe ( C ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taza ( r ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo ( t ) :";
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(176, 64);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(100, 20);
            this.textImporte.TabIndex = 3;
            // 
            // textTaza
            // 
            this.textTaza.Location = new System.Drawing.Point(176, 100);
            this.textTaza.Name = "textTaza";
            this.textTaza.Size = new System.Drawing.Size(100, 20);
            this.textTaza.TabIndex = 4;
            // 
            // textTiempo
            // 
            this.textTiempo.Location = new System.Drawing.Point(176, 138);
            this.textTiempo.Name = "textTiempo";
            this.textTiempo.Size = new System.Drawing.Size(100, 20);
            this.textTiempo.TabIndex = 5;
            // 
            // comboTiempo
            // 
            this.comboTiempo.FormattingEnabled = true;
            this.comboTiempo.Items.AddRange(new object[] {
            "Años",
            "Meses",
            "Dias"});
            this.comboTiempo.Location = new System.Drawing.Point(314, 138);
            this.comboTiempo.Name = "comboTiempo";
            this.comboTiempo.Size = new System.Drawing.Size(53, 21);
            this.comboTiempo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(156, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboTaza
            // 
            this.comboTaza.FormattingEnabled = true;
            this.comboTaza.Items.AddRange(new object[] {
            "Años",
            "Meses",
            "Dias"});
            this.comboTaza.Location = new System.Drawing.Point(314, 100);
            this.comboTaza.Name = "comboTaza";
            this.comboTaza.Size = new System.Drawing.Size(53, 21);
            this.comboTaza.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(282, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "%";
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.Khaki;
            this.botonBorrar.Location = new System.Drawing.Point(259, 193);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(60, 23);
            this.botonBorrar.TabIndex = 10;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // InteresSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::CalculadoraFinancieraLaboratio2020.Properties.Resources.cash_coins_currency_finance_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(690, 288);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTaza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboTiempo);
            this.Controls.Add(this.textTiempo);
            this.Controls.Add(this.textTaza);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InteresSimple";
            this.Text = "Interes Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.TextBox textTaza;
        private System.Windows.Forms.TextBox textTiempo;
        private System.Windows.Forms.ComboBox comboTiempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboTaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonBorrar;
    }
}