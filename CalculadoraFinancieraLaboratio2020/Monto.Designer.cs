namespace CalculadoraFinancieraLaboratio2020
{
    partial class Monto
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
            this.textImporte = new System.Windows.Forms.TextBox();
            this.textInteres = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe ( C ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interes ( I ) :";
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(314, 87);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(100, 20);
            this.textImporte.TabIndex = 2;
            // 
            // textInteres
            // 
            this.textInteres.Location = new System.Drawing.Point(314, 134);
            this.textInteres.Name = "textInteres";
            this.textInteres.Size = new System.Drawing.Size(100, 20);
            this.textInteres.TabIndex = 3;
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.AliceBlue;
            this.botonCalcular.Location = new System.Drawing.Point(241, 201);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 4;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = false;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.White;
            this.botonBorrar.Location = new System.Drawing.Point(339, 201);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 5;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // Monto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CalculadoraFinancieraLaboratio2020.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(517, 332);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.textInteres);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Monto";
            this.Text = "Monto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.TextBox textInteres;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonBorrar;
    }
}