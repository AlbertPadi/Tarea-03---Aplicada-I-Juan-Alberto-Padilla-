namespace ProyectoImprimir
{
    partial class Ejercicio_1
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
            this.textBoxLado = new System.Windows.Forms.TextBox();
            this.labelLado = new System.Windows.Forms.Label();
            this.textBoxLongitud = new System.Windows.Forms.TextBox();
            this.labelLongitu = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLado
            // 
            this.textBoxLado.Location = new System.Drawing.Point(85, 55);
            this.textBoxLado.Name = "textBoxLado";
            this.textBoxLado.Size = new System.Drawing.Size(100, 20);
            this.textBoxLado.TabIndex = 0;
            this.textBoxLado.TextChanged += new System.EventHandler(this.textBoxLado_TextChanged);
            // 
            // labelLado
            // 
            this.labelLado.AutoSize = true;
            this.labelLado.Location = new System.Drawing.Point(33, 55);
            this.labelLado.Name = "labelLado";
            this.labelLado.Size = new System.Drawing.Size(31, 13);
            this.labelLado.TabIndex = 1;
            this.labelLado.Text = "Lado";
            // 
            // textBoxLongitud
            // 
            this.textBoxLongitud.Location = new System.Drawing.Point(85, 90);
            this.textBoxLongitud.Name = "textBoxLongitud";
            this.textBoxLongitud.Size = new System.Drawing.Size(100, 20);
            this.textBoxLongitud.TabIndex = 2;
            // 
            // labelLongitu
            // 
            this.labelLongitu.AutoSize = true;
            this.labelLongitu.Location = new System.Drawing.Point(33, 93);
            this.labelLongitu.Name = "labelLongitu";
            this.labelLongitu.Size = new System.Drawing.Size(48, 13);
            this.labelLongitu.TabIndex = 3;
            this.labelLongitu.Text = "Longitud";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(99, 136);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(85, 185);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultado.TabIndex = 5;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(108, 208);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "Resultado";
            // 
            // Ejercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelLongitu);
            this.Controls.Add(this.textBoxLongitud);
            this.Controls.Add(this.labelLado);
            this.Controls.Add(this.textBoxLado);
            this.Name = "Ejercicio_1";
            this.Text = "Ejercicio_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLado;
        private System.Windows.Forms.Label labelLado;
        private System.Windows.Forms.TextBox textBoxLongitud;
        private System.Windows.Forms.Label labelLongitu;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label labelResultado;
    }
}