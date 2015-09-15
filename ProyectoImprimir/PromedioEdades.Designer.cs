namespace ProyectoImprimir
{
    partial class PromedioEdades
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
            this.textBoxEdad1 = new System.Windows.Forms.TextBox();
            this.textBoxEdad2 = new System.Windows.Forms.TextBox();
            this.textBoxEdad3 = new System.Windows.Forms.TextBox();
            this.textBoxEdad4 = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxPromedio = new System.Windows.Forms.TextBox();
            this.textBoxMayor = new System.Windows.Forms.TextBox();
            this.textBoxMenor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar edades";
            // 
            // textBoxEdad1
            // 
            this.textBoxEdad1.Location = new System.Drawing.Point(73, 59);
            this.textBoxEdad1.Name = "textBoxEdad1";
            this.textBoxEdad1.Size = new System.Drawing.Size(44, 20);
            this.textBoxEdad1.TabIndex = 1;
            // 
            // textBoxEdad2
            // 
            this.textBoxEdad2.Location = new System.Drawing.Point(12, 59);
            this.textBoxEdad2.Name = "textBoxEdad2";
            this.textBoxEdad2.Size = new System.Drawing.Size(38, 20);
            this.textBoxEdad2.TabIndex = 0;
            // 
            // textBoxEdad3
            // 
            this.textBoxEdad3.Location = new System.Drawing.Point(142, 59);
            this.textBoxEdad3.Name = "textBoxEdad3";
            this.textBoxEdad3.Size = new System.Drawing.Size(44, 20);
            this.textBoxEdad3.TabIndex = 2;
            // 
            // textBoxEdad4
            // 
            this.textBoxEdad4.Location = new System.Drawing.Point(213, 59);
            this.textBoxEdad4.Name = "textBoxEdad4";
            this.textBoxEdad4.Size = new System.Drawing.Size(41, 20);
            this.textBoxEdad4.TabIndex = 3;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(105, 103);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            this.buttonCalcular.Enter += new System.EventHandler(this.buttonCalcular_Enter);
            // 
            // textBoxPromedio
            // 
            this.textBoxPromedio.Location = new System.Drawing.Point(96, 156);
            this.textBoxPromedio.Name = "textBoxPromedio";
            this.textBoxPromedio.ReadOnly = true;
            this.textBoxPromedio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPromedio.TabIndex = 6;
            // 
            // textBoxMayor
            // 
            this.textBoxMayor.Location = new System.Drawing.Point(96, 192);
            this.textBoxMayor.Name = "textBoxMayor";
            this.textBoxMayor.ReadOnly = true;
            this.textBoxMayor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMayor.TabIndex = 7;
            // 
            // textBoxMenor
            // 
            this.textBoxMenor.Location = new System.Drawing.Point(96, 230);
            this.textBoxMenor.Name = "textBoxMenor";
            this.textBoxMenor.ReadOnly = true;
            this.textBoxMenor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMenor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mayor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Menor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Promedio";
            // 
            // PromedioEdades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMenor);
            this.Controls.Add(this.textBoxMayor);
            this.Controls.Add(this.textBoxPromedio);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxEdad4);
            this.Controls.Add(this.textBoxEdad3);
            this.Controls.Add(this.textBoxEdad2);
            this.Controls.Add(this.textBoxEdad1);
            this.Controls.Add(this.label1);
            this.Name = "PromedioEdades";
            this.Text = "PromedioEdades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEdad1;
        private System.Windows.Forms.TextBox textBoxEdad2;
        private System.Windows.Forms.TextBox textBoxEdad3;
        private System.Windows.Forms.TextBox textBoxEdad4;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxPromedio;
        private System.Windows.Forms.TextBox textBoxMayor;
        private System.Windows.Forms.TextBox textBoxMenor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}