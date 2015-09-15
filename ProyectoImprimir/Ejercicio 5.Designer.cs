namespace ProyectoImprimir
{
    partial class Ejercicio_5
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
            this.labelDollar = new System.Windows.Forms.Label();
            this.labelEuro = new System.Windows.Forms.Label();
            this.textBoxDollar = new System.Windows.Forms.TextBox();
            this.textBoxEuro = new System.Windows.Forms.TextBox();
            this.labelTasaDollar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCD = new System.Windows.Forms.TextBox();
            this.textBoxCE = new System.Windows.Forms.TextBox();
            this.buttonCambio = new System.Windows.Forms.Button();
            this.buttonCambio1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDollar
            // 
            this.labelDollar.AutoSize = true;
            this.labelDollar.Location = new System.Drawing.Point(27, 83);
            this.labelDollar.Name = "labelDollar";
            this.labelDollar.Size = new System.Drawing.Size(34, 13);
            this.labelDollar.TabIndex = 0;
            this.labelDollar.Text = "Dollar";
            this.labelDollar.Click += new System.EventHandler(this.labelDollar_Click);
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Location = new System.Drawing.Point(27, 133);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(29, 13);
            this.labelEuro.TabIndex = 1;
            this.labelEuro.Text = "Euro";
            // 
            // textBoxDollar
            // 
            this.textBoxDollar.Location = new System.Drawing.Point(81, 80);
            this.textBoxDollar.Name = "textBoxDollar";
            this.textBoxDollar.Size = new System.Drawing.Size(100, 20);
            this.textBoxDollar.TabIndex = 2;
            this.textBoxDollar.TextChanged += new System.EventHandler(this.textBoxDollar_TextChanged);
            // 
            // textBoxEuro
            // 
            this.textBoxEuro.Location = new System.Drawing.Point(81, 130);
            this.textBoxEuro.Name = "textBoxEuro";
            this.textBoxEuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuro.TabIndex = 3;
            // 
            // labelTasaDollar
            // 
            this.labelTasaDollar.AutoSize = true;
            this.labelTasaDollar.Location = new System.Drawing.Point(78, 33);
            this.labelTasaDollar.Name = "labelTasaDollar";
            this.labelTasaDollar.Size = new System.Drawing.Size(61, 13);
            this.labelTasaDollar.TabIndex = 5;
            this.labelTasaDollar.Text = "Tasa Dollar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tasa Euro";
            // 
            // textBoxCD
            // 
            this.textBoxCD.Location = new System.Drawing.Point(266, 80);
            this.textBoxCD.Name = "textBoxCD";
            this.textBoxCD.ReadOnly = true;
            this.textBoxCD.Size = new System.Drawing.Size(100, 20);
            this.textBoxCD.TabIndex = 8;
            this.textBoxCD.TextChanged += new System.EventHandler(this.textBoxCD_TextChanged);
            // 
            // textBoxCE
            // 
            this.textBoxCE.Location = new System.Drawing.Point(266, 133);
            this.textBoxCE.Name = "textBoxCE";
            this.textBoxCE.ReadOnly = true;
            this.textBoxCE.Size = new System.Drawing.Size(100, 20);
            this.textBoxCE.TabIndex = 9;
            // 
            // buttonCambio
            // 
            this.buttonCambio.Location = new System.Drawing.Point(187, 80);
            this.buttonCambio.Name = "buttonCambio";
            this.buttonCambio.Size = new System.Drawing.Size(75, 23);
            this.buttonCambio.TabIndex = 10;
            this.buttonCambio.Text = "Cambio";
            this.buttonCambio.UseVisualStyleBackColor = true;
            this.buttonCambio.Click += new System.EventHandler(this.buttonCambio_Click);
            // 
            // buttonCambio1
            // 
            this.buttonCambio1.Location = new System.Drawing.Point(187, 133);
            this.buttonCambio1.Name = "buttonCambio1";
            this.buttonCambio1.Size = new System.Drawing.Size(75, 23);
            this.buttonCambio1.TabIndex = 11;
            this.buttonCambio1.Text = "Cambio";
            this.buttonCambio1.UseVisualStyleBackColor = true;
            this.buttonCambio1.Click += new System.EventHandler(this.buttonCambio1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "0.89";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "1.19";
            // 
            // Ejercicio_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCambio1);
            this.Controls.Add(this.buttonCambio);
            this.Controls.Add(this.textBoxCE);
            this.Controls.Add(this.textBoxCD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTasaDollar);
            this.Controls.Add(this.textBoxEuro);
            this.Controls.Add(this.textBoxDollar);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.labelDollar);
            this.Name = "Ejercicio_5";
            this.Text = "Ejercicio_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDollar;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.TextBox textBoxDollar;
        private System.Windows.Forms.TextBox textBoxEuro;
        private System.Windows.Forms.Label labelTasaDollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCD;
        private System.Windows.Forms.TextBox textBoxCE;
        private System.Windows.Forms.Button buttonCambio;
        private System.Windows.Forms.Button buttonCambio1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}