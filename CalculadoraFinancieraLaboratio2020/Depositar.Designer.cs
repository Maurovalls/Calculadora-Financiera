namespace CalculadoraFinancieraLaboratio2020
{
    partial class Depositar
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
            this.label4 = new System.Windows.Forms.Label();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.textTaza = new System.Windows.Forms.TextBox();
            this.textTiempo = new System.Windows.Forms.TextBox();
            this.comboElegir = new System.Windows.Forms.ComboBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe deseado :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(64, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taza ( r ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(53, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo ( t ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(119, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "¿Queres saber cuanto depositar?";
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(141, 72);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(100, 20);
            this.textImporte.TabIndex = 4;
            // 
            // textTaza
            // 
            this.textTaza.Location = new System.Drawing.Point(141, 105);
            this.textTaza.Name = "textTaza";
            this.textTaza.Size = new System.Drawing.Size(100, 20);
            this.textTaza.TabIndex = 5;
            // 
            // textTiempo
            // 
            this.textTiempo.Location = new System.Drawing.Point(141, 138);
            this.textTiempo.Name = "textTiempo";
            this.textTiempo.Size = new System.Drawing.Size(100, 20);
            this.textTiempo.TabIndex = 6;
            // 
            // comboElegir
            // 
            this.comboElegir.FormattingEnabled = true;
            this.comboElegir.Items.AddRange(new object[] {
            "Años",
            "Meses"});
            this.comboElegir.Location = new System.Drawing.Point(307, 138);
            this.comboElegir.Name = "comboElegir";
            this.comboElegir.Size = new System.Drawing.Size(56, 21);
            this.comboElegir.TabIndex = 7;
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.Khaki;
            this.botonCalcular.Location = new System.Drawing.Point(98, 201);
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
            this.botonBorrar.Location = new System.Drawing.Point(211, 201);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 9;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(247, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraFinancieraLaboratio2020.Properties.Resources.gafas_calculadora_tableta_blanco_escritorio_aseado_1387_287;
            this.ClientSize = new System.Drawing.Size(567, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.comboElegir);
            this.Controls.Add(this.textTiempo);
            this.Controls.Add(this.textTaza);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Depositar";
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.TextBox textTaza;
        private System.Windows.Forms.TextBox textTiempo;
        private System.Windows.Forms.ComboBox comboElegir;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Label label5;
    }
}