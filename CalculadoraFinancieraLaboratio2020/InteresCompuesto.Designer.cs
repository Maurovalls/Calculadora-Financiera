namespace CalculadoraFinancieraLaboratio2020
{
    partial class InteresCompuesto
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
            this.textImporte2 = new System.Windows.Forms.TextBox();
            this.textTaza2 = new System.Windows.Forms.TextBox();
            this.textTiempo2 = new System.Windows.Forms.TextBox();
            this.comboTiempo2 = new System.Windows.Forms.ComboBox();
            this.comboTaza2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe ( C ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taza ( r ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo ( t ) :";
            // 
            // textImporte2
            // 
            this.textImporte2.Location = new System.Drawing.Point(154, 45);
            this.textImporte2.Name = "textImporte2";
            this.textImporte2.Size = new System.Drawing.Size(100, 20);
            this.textImporte2.TabIndex = 3;
            // 
            // textTaza2
            // 
            this.textTaza2.Location = new System.Drawing.Point(154, 81);
            this.textTaza2.Name = "textTaza2";
            this.textTaza2.Size = new System.Drawing.Size(100, 20);
            this.textTaza2.TabIndex = 4;
            // 
            // textTiempo2
            // 
            this.textTiempo2.Location = new System.Drawing.Point(154, 118);
            this.textTiempo2.Name = "textTiempo2";
            this.textTiempo2.Size = new System.Drawing.Size(100, 20);
            this.textTiempo2.TabIndex = 5;
            // 
            // comboTiempo2
            // 
            this.comboTiempo2.FormattingEnabled = true;
            this.comboTiempo2.Items.AddRange(new object[] {
            "Años",
            "Meses"});
            this.comboTiempo2.Location = new System.Drawing.Point(293, 118);
            this.comboTiempo2.Name = "comboTiempo2";
            this.comboTiempo2.Size = new System.Drawing.Size(52, 21);
            this.comboTiempo2.TabIndex = 6;
            // 
            // comboTaza2
            // 
            this.comboTaza2.FormattingEnabled = true;
            this.comboTaza2.Items.AddRange(new object[] {
            "Años",
            "Meses"});
            this.comboTaza2.Location = new System.Drawing.Point(293, 81);
            this.comboTaza2.Name = "comboTaza2";
            this.comboTaza2.Size = new System.Drawing.Size(52, 21);
            this.comboTaza2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(260, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "%";
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.Khaki;
            this.botonCalcular.Location = new System.Drawing.Point(154, 185);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(58, 23);
            this.botonCalcular.TabIndex = 9;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = false;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.Khaki;
            this.botonBorrar.Location = new System.Drawing.Point(242, 185);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(63, 23);
            this.botonBorrar.TabIndex = 10;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // InteresCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CalculadoraFinancieraLaboratio2020.Properties.Resources.cash_coins_currency_finance_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(684, 276);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTaza2);
            this.Controls.Add(this.comboTiempo2);
            this.Controls.Add(this.textTiempo2);
            this.Controls.Add(this.textTaza2);
            this.Controls.Add(this.textImporte2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InteresCompuesto";
            this.Text = "Interes Compuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textImporte2;
        private System.Windows.Forms.TextBox textTaza2;
        private System.Windows.Forms.TextBox textTiempo2;
        private System.Windows.Forms.ComboBox comboTiempo2;
        private System.Windows.Forms.ComboBox comboTaza2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonBorrar;
    }
}