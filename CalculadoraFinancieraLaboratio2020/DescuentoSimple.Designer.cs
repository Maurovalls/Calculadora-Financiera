namespace CalculadoraFinancieraLaboratio2020
{
    partial class DescuentoSimple
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
            this.comboDescuento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.textDescuento = new System.Windows.Forms.TextBox();
            this.textTiempo = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.comboTaza = new System.Windows.Forms.ComboBox();
            this.comboTiempo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboDescuento
            // 
            this.comboDescuento.FormattingEnabled = true;
            this.comboDescuento.Items.AddRange(new object[] {
            "Comercial",
            "Racional"});
            this.comboDescuento.Location = new System.Drawing.Point(260, 12);
            this.comboDescuento.Name = "comboDescuento";
            this.comboDescuento.Size = new System.Drawing.Size(79, 21);
            this.comboDescuento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto ( M ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo ( n ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Taza de descuento ( d ) :";
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(156, 54);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(100, 20);
            this.textMonto.TabIndex = 4;
            // 
            // textDescuento
            // 
            this.textDescuento.Location = new System.Drawing.Point(156, 85);
            this.textDescuento.Name = "textDescuento";
            this.textDescuento.Size = new System.Drawing.Size(100, 20);
            this.textDescuento.TabIndex = 6;
            // 
            // textTiempo
            // 
            this.textTiempo.Location = new System.Drawing.Point(156, 119);
            this.textTiempo.Name = "textTiempo";
            this.textTiempo.Size = new System.Drawing.Size(100, 20);
            this.textTiempo.TabIndex = 7;
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.Khaki;
            this.botonCalcular.Location = new System.Drawing.Point(459, 78);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 8;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = false;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.Khaki;
            this.botonBorrar.Location = new System.Drawing.Point(459, 117);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 9;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // comboTaza
            // 
            this.comboTaza.FormattingEnabled = true;
            this.comboTaza.Items.AddRange(new object[] {
            "Años",
            "Meses"});
            this.comboTaza.Location = new System.Drawing.Point(300, 84);
            this.comboTaza.Name = "comboTaza";
            this.comboTaza.Size = new System.Drawing.Size(56, 21);
            this.comboTaza.TabIndex = 10;
            // 
            // comboTiempo
            // 
            this.comboTiempo.FormattingEnabled = true;
            this.comboTiempo.Items.AddRange(new object[] {
            "Años",
            "Meses"});
            this.comboTiempo.Location = new System.Drawing.Point(300, 119);
            this.comboTiempo.Name = "comboTiempo";
            this.comboTiempo.Size = new System.Drawing.Size(56, 21);
            this.comboTiempo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(267, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "%";
            // 
            // DescuentoSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CalculadoraFinancieraLaboratio2020.Properties.Resources.beneficio_1;
            this.ClientSize = new System.Drawing.Size(613, 323);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTiempo);
            this.Controls.Add(this.comboTaza);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.textTiempo);
            this.Controls.Add(this.textDescuento);
            this.Controls.Add(this.textMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDescuento);
            this.Name = "DescuentoSimple";
            this.Text = "Descuento Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.TextBox textDescuento;
        private System.Windows.Forms.TextBox textTiempo;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.ComboBox comboTaza;
        private System.Windows.Forms.ComboBox comboTiempo;
        private System.Windows.Forms.Label label4;
    }
}