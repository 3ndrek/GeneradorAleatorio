namespace GeneradorAleatorio.Pantallas
{
    partial class GeneadorUniforme
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
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(378, 87);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(158, 26);
            this.TxtA.TabIndex = 0;
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(378, 205);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(158, 26);
            this.TxtB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el valor del límite superior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el valor del límite inferior";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(557, 344);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(120, 38);
            this.BtnGenerar.TabIndex = 4;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            // 
            // GeneadorUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 445);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtA);
            this.Name = "GeneadorUniforme";
            this.Text = "Generador Uniforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneadorUniforme_FormClosing);
            this.Load += new System.EventHandler(this.GeneadorUniforme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGenerar;
    }
}