namespace ProyectoImprimir
{
    partial class Ejercicio_4
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
            this.textBoxCentigrados = new System.Windows.Forms.TextBox();
            this.labelCentigrados = new System.Windows.Forms.Label();
            this.buttonConvertir = new System.Windows.Forms.Button();
            this.textBoxFahrenheit = new System.Windows.Forms.TextBox();
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCentigrados
            // 
            this.textBoxCentigrados.Location = new System.Drawing.Point(99, 59);
            this.textBoxCentigrados.Name = "textBoxCentigrados";
            this.textBoxCentigrados.Size = new System.Drawing.Size(100, 20);
            this.textBoxCentigrados.TabIndex = 0;
            this.textBoxCentigrados.TextChanged += new System.EventHandler(this.textBoxCentigrados_TextChanged);
            // 
            // labelCentigrados
            // 
            this.labelCentigrados.AutoSize = true;
            this.labelCentigrados.Location = new System.Drawing.Point(30, 62);
            this.labelCentigrados.Name = "labelCentigrados";
            this.labelCentigrados.Size = new System.Drawing.Size(63, 13);
            this.labelCentigrados.TabIndex = 1;
            this.labelCentigrados.Text = "Centigrados";
            // 
            // buttonConvertir
            // 
            this.buttonConvertir.Location = new System.Drawing.Point(109, 100);
            this.buttonConvertir.Name = "buttonConvertir";
            this.buttonConvertir.Size = new System.Drawing.Size(75, 23);
            this.buttonConvertir.TabIndex = 2;
            this.buttonConvertir.Text = "Convertir";
            this.buttonConvertir.UseVisualStyleBackColor = true;
            this.buttonConvertir.Click += new System.EventHandler(this.buttonConvertir_Click);
            // 
            // textBoxFahrenheit
            // 
            this.textBoxFahrenheit.Location = new System.Drawing.Point(99, 142);
            this.textBoxFahrenheit.Name = "textBoxFahrenheit";
            this.textBoxFahrenheit.ReadOnly = true;
            this.textBoxFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.textBoxFahrenheit.TabIndex = 3;
            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.Location = new System.Drawing.Point(30, 145);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.labelFahrenheit.TabIndex = 4;
            this.labelFahrenheit.Text = "Fahrenheit";
            // 
            // Ejercicio_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelFahrenheit);
            this.Controls.Add(this.textBoxFahrenheit);
            this.Controls.Add(this.buttonConvertir);
            this.Controls.Add(this.labelCentigrados);
            this.Controls.Add(this.textBoxCentigrados);
            this.Name = "Ejercicio_4";
            this.Text = "Ejercicio_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCentigrados;
        private System.Windows.Forms.Label labelCentigrados;
        private System.Windows.Forms.Button buttonConvertir;
        private System.Windows.Forms.TextBox textBoxFahrenheit;
        private System.Windows.Forms.Label labelFahrenheit;
    }
}