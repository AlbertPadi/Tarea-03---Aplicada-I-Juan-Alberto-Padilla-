namespace ProyectoImprimir
{
    partial class MetodoGradoARadianes
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.Dato = new System.Windows.Forms.Label();
            this.textBoxDato = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(111, 88);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Dato
            // 
            this.Dato.AutoSize = true;
            this.Dato.Location = new System.Drawing.Point(12, 36);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(83, 13);
            this.Dato.TabIndex = 1;
            this.Dato.Text = "Dato a convertir";
            // 
            // textBoxDato
            // 
            this.textBoxDato.Location = new System.Drawing.Point(102, 36);
            this.textBoxDato.Name = "textBoxDato";
            this.textBoxDato.Size = new System.Drawing.Size(100, 20);
            this.textBoxDato.TabIndex = 2;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(102, 151);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultado.TabIndex = 3;
            // 
            // MetodoGradoARadianes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxDato);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.buttonCalcular);
            this.Name = "MetodoGradoARadianes";
            this.Text = "MetodoGradoARadianes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label Dato;
        private System.Windows.Forms.TextBox textBoxDato;
        private System.Windows.Forms.TextBox textBoxResultado;
    }
}