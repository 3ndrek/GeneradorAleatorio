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
            this.LimSup = new System.Windows.Forms.TextBox();
            this.LimInf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.CantNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LimSup
            // 
            this.LimSup.Location = new System.Drawing.Point(252, 57);
            this.LimSup.Margin = new System.Windows.Forms.Padding(2);
            this.LimSup.Name = "LimSup";
            this.LimSup.Size = new System.Drawing.Size(107, 20);
            this.LimSup.TabIndex = 0;
            // 
            // LimInf
            // 
            this.LimInf.Location = new System.Drawing.Point(252, 108);
            this.LimInf.Margin = new System.Windows.Forms.Padding(2);
            this.LimInf.Name = "LimInf";
            this.LimInf.Size = new System.Drawing.Size(107, 20);
            this.LimInf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el valor del límite superior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el valor del límite inferior";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(371, 224);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(80, 25);
            this.BtnGenerar.TabIndex = 4;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // CantNum
            // 
            this.CantNum.Location = new System.Drawing.Point(252, 156);
            this.CantNum.Name = "CantNum";
            this.CantNum.Size = new System.Drawing.Size(107, 20);
            this.CantNum.TabIndex = 5;
            // 
            // GeneadorUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 301);
            this.Controls.Add(this.CantNum);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimInf);
            this.Controls.Add(this.LimSup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GeneadorUniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Uniforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneadorUniforme_FormClosing);
            this.Load += new System.EventHandler(this.GeneadorUniforme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LimSup;
        private System.Windows.Forms.TextBox LimInf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.TextBox CantNum;
    }
}