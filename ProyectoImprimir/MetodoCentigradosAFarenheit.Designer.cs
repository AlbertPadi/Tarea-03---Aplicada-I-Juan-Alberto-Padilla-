namespace ProyectoImprimir
{
    partial class MetodoCentigradosAFarenheit
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
            this.textBoxCentigrados = new System.Windows.Forms.TextBox();
            this.buttonConvertir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFarenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centigradios";
            // 
            // textBoxCentigrados
            // 
            this.textBoxCentigrados.Location = new System.Drawing.Point(103, 34);
            this.textBoxCentigrados.Name = "textBoxCentigrados";
            this.textBoxCentigrados.Size = new System.Drawing.Size(100, 20);
            this.textBoxCentigrados.TabIndex = 1;
            // 
            // buttonConvertir
            // 
            this.buttonConvertir.Location = new System.Drawing.Point(113, 82);
            this.buttonConvertir.Name = "buttonConvertir";
            this.buttonConvertir.Size = new System.Drawing.Size(75, 23);
            this.buttonConvertir.TabIndex = 2;
            this.buttonConvertir.Text = "Convertir";
            this.buttonConvertir.UseVisualStyleBackColor = true;
            this.buttonConvertir.Click += new System.EventHandler(this.buttonConvertir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Farenheit";
            // 
            // textBoxFarenheit
            // 
            this.textBoxFarenheit.Location = new System.Drawing.Point(103, 154);
            this.textBoxFarenheit.Name = "textBoxFarenheit";
            this.textBoxFarenheit.ReadOnly = true;
            this.textBoxFarenheit.Size = new System.Drawing.Size(100, 20);
            this.textBoxFarenheit.TabIndex = 4;
            // 
            // MetodoCentigradosAFarenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxFarenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConvertir);
            this.Controls.Add(this.textBoxCentigrados);
            this.Controls.Add(this.label1);
            this.Name = "MetodoCentigradosAFarenheit";
            this.Text = "MetodoCentigradosAFarenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCentigrados;
        private System.Windows.Forms.Button buttonConvertir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFarenheit;
    }
}