namespace ProyectoImprimir
{
    partial class Area_y_Perimetro_de_poligono
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
            this.buttonPerimetro = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Perimetro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calcular Area";
            // 
            // buttonPerimetro
            // 
            this.buttonPerimetro.Location = new System.Drawing.Point(44, 40);
            this.buttonPerimetro.Name = "buttonPerimetro";
            this.buttonPerimetro.Size = new System.Drawing.Size(75, 23);
            this.buttonPerimetro.TabIndex = 2;
            this.buttonPerimetro.Text = "Perimetro";
            this.buttonPerimetro.UseVisualStyleBackColor = true;
            this.buttonPerimetro.Click += new System.EventHandler(this.buttonPerimetro_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(161, 40);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 3;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // Area_y_Perimetro_de_poligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonPerimetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Area_y_Perimetro_de_poligono";
            this.Text = "Area_y_Perimetro_de_poligono";
            this.Load += new System.EventHandler(this.Area_y_Perimetro_de_poligono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPerimetro;
        private System.Windows.Forms.Button buttonArea;
    }
}