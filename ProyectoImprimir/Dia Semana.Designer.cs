namespace ProyectoImprimir
{
    partial class Dia_Semana
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
            this.textBoxDia = new System.Windows.Forms.TextBox();
            this.labelDia = new System.Windows.Forms.Label();
            this.buttonComprobar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCompDia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDia
            // 
            this.textBoxDia.Location = new System.Drawing.Point(104, 50);
            this.textBoxDia.Name = "textBoxDia";
            this.textBoxDia.Size = new System.Drawing.Size(132, 20);
            this.textBoxDia.TabIndex = 0;
            this.textBoxDia.TextChanged += new System.EventHandler(this.textBoxDia_TextChanged);
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(24, 53);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(74, 13);
            this.labelDia.TabIndex = 1;
            this.labelDia.Text = "Ingrese un dia";
            // 
            // buttonComprobar
            // 
            this.buttonComprobar.Location = new System.Drawing.Point(133, 87);
            this.buttonComprobar.Name = "buttonComprobar";
            this.buttonComprobar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprobar.TabIndex = 2;
            this.buttonComprobar.Text = "Comprobar";
            this.buttonComprobar.UseVisualStyleBackColor = true;
            this.buttonComprobar.Click += new System.EventHandler(this.buttonComprobar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "El dia es";
            // 
            // textBoxCompDia
            // 
            this.textBoxCompDia.Location = new System.Drawing.Point(104, 132);
            this.textBoxCompDia.Name = "textBoxCompDia";
            this.textBoxCompDia.Size = new System.Drawing.Size(132, 20);
            this.textBoxCompDia.TabIndex = 4;
            // 
            // Dia_Semana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxCompDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonComprobar);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.textBoxDia);
            this.Name = "Dia_Semana";
            this.Text = "Dia_Semana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDia;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Button buttonComprobar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCompDia;
    }
}