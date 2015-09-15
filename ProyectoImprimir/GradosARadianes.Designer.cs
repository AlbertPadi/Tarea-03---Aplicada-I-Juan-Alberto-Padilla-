namespace ProyectoImprimir
{
    partial class GradosARadianes
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
            this.textBoxDato = new System.Windows.Forms.TextBox();
            this.textBoxRadianes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConvertir = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato a convertir";
            // 
            // textBoxDato
            // 
            this.textBoxDato.Location = new System.Drawing.Point(115, 51);
            this.textBoxDato.Name = "textBoxDato";
            this.textBoxDato.Size = new System.Drawing.Size(100, 20);
            this.textBoxDato.TabIndex = 1;
            this.textBoxDato.TextChanged += new System.EventHandler(this.textBoxDato_TextChanged);
            // 
            // textBoxRadianes
            // 
            this.textBoxRadianes.Location = new System.Drawing.Point(115, 104);
            this.textBoxRadianes.Name = "textBoxRadianes";
            this.textBoxRadianes.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadianes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese radianes";
            // 
            // buttonConvertir
            // 
            this.buttonConvertir.Location = new System.Drawing.Point(125, 144);
            this.buttonConvertir.Name = "buttonConvertir";
            this.buttonConvertir.Size = new System.Drawing.Size(75, 23);
            this.buttonConvertir.TabIndex = 4;
            this.buttonConvertir.Text = "Convertir";
            this.buttonConvertir.UseVisualStyleBackColor = true;
            this.buttonConvertir.Click += new System.EventHandler(this.buttonConvertir_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(115, 190);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // GradosARadianes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonConvertir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRadianes);
            this.Controls.Add(this.textBoxDato);
            this.Controls.Add(this.label1);
            this.Name = "GradosARadianes";
            this.Text = "GradosARadianes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDato;
        private System.Windows.Forms.TextBox textBoxRadianes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConvertir;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label label3;
    }
}