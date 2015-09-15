namespace ProyectoImprimir
{
    partial class Ejercicio_2cap3
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
            this.GradosARadianes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RadianesAGrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De grado a radianes";
            // 
            // GradosARadianes
            // 
            this.GradosARadianes.Location = new System.Drawing.Point(142, 19);
            this.GradosARadianes.Name = "GradosARadianes";
            this.GradosARadianes.Size = new System.Drawing.Size(75, 23);
            this.GradosARadianes.TabIndex = 1;
            this.GradosARadianes.Text = "Ir a conversor";
            this.GradosARadianes.UseVisualStyleBackColor = true;
            this.GradosARadianes.Click += new System.EventHandler(this.GradosARadianes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Da readianes a grado";
            // 
            // RadianesAGrado
            // 
            this.RadianesAGrado.Location = new System.Drawing.Point(142, 62);
            this.RadianesAGrado.Name = "RadianesAGrado";
            this.RadianesAGrado.Size = new System.Drawing.Size(75, 23);
            this.RadianesAGrado.TabIndex = 3;
            this.RadianesAGrado.Text = "Ir a conversor";
            this.RadianesAGrado.UseVisualStyleBackColor = true;
            // 
            // Ejercicio_2cap3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 111);
            this.Controls.Add(this.RadianesAGrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GradosARadianes);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio_2cap3";
            this.Text = "Ejercicio_2cap3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GradosARadianes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RadianesAGrado;
    }
}