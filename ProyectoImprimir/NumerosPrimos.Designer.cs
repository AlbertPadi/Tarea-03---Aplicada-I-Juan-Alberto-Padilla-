namespace ProyectoImprimir
{
    partial class NumerosPrimos
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
            this.buttonPrimos = new System.Windows.Forms.Button();
            this.richTextBoxResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonPrimos
            // 
            this.buttonPrimos.Location = new System.Drawing.Point(99, 12);
            this.buttonPrimos.Name = "buttonPrimos";
            this.buttonPrimos.Size = new System.Drawing.Size(75, 23);
            this.buttonPrimos.TabIndex = 0;
            this.buttonPrimos.Text = "Ver Primos";
            this.buttonPrimos.UseVisualStyleBackColor = true;
            this.buttonPrimos.Click += new System.EventHandler(this.buttonPrimos_Click);
            // 
            // richTextBoxResultado
            // 
            this.richTextBoxResultado.Location = new System.Drawing.Point(90, 65);
            this.richTextBoxResultado.Name = "richTextBoxResultado";
            this.richTextBoxResultado.ReadOnly = true;
            this.richTextBoxResultado.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxResultado.TabIndex = 2;
            this.richTextBoxResultado.Text = "";
            // 
            // NumerosPrimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBoxResultado);
            this.Controls.Add(this.buttonPrimos);
            this.Name = "NumerosPrimos";
            this.Text = "NumerosPrimos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrimos;
        private System.Windows.Forms.RichTextBox richTextBoxResultado;
    }
}