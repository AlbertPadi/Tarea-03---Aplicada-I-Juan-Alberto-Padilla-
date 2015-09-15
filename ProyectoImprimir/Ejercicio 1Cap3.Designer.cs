namespace ProyectoImprimir
{
    partial class NumeroParoImpar
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonComprobar = new System.Windows.Forms.Button();
            this.textBoxPrueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(39, 37);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Numero";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(89, 34);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 1;
            // 
            // buttonComprobar
            // 
            this.buttonComprobar.Location = new System.Drawing.Point(99, 80);
            this.buttonComprobar.Name = "buttonComprobar";
            this.buttonComprobar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprobar.TabIndex = 2;
            this.buttonComprobar.Text = "Comprobar";
            this.buttonComprobar.UseVisualStyleBackColor = true;
            this.buttonComprobar.Click += new System.EventHandler(this.buttonComprobar_Click);
            // 
            // textBoxPrueba
            // 
            this.textBoxPrueba.Location = new System.Drawing.Point(89, 129);
            this.textBoxPrueba.Name = "textBoxPrueba";
            this.textBoxPrueba.ReadOnly = true;
            this.textBoxPrueba.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrueba.TabIndex = 3;
            // 
            // NumeroParoImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxPrueba);
            this.Controls.Add(this.buttonComprobar);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Name = "NumeroParoImpar";
            this.Text = "Numero par o impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonComprobar;
        private System.Windows.Forms.TextBox textBoxPrueba;
    }
}