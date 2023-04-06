namespace GeneradorAleatorio.Pantallas
{
    partial class PantallaSeleccionModo
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
            this.BtnUniforme = new System.Windows.Forms.Button();
            this.BtnNormal = new System.Windows.Forms.Button();
            this.BtnPoisson = new System.Windows.Forms.Button();
            this.BtnExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la distribución a generar";
            // 
            // BtnUniforme
            // 
            this.BtnUniforme.Location = new System.Drawing.Point(26, 272);
            this.BtnUniforme.Name = "BtnUniforme";
            this.BtnUniforme.Size = new System.Drawing.Size(251, 73);
            this.BtnUniforme.TabIndex = 2;
            this.BtnUniforme.Text = "Uniforme";
            this.BtnUniforme.UseVisualStyleBackColor = true;
            this.BtnUniforme.Click += new System.EventHandler(this.BtnUniforme_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Location = new System.Drawing.Point(327, 272);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(251, 73);
            this.BtnNormal.TabIndex = 3;
            this.BtnNormal.Text = "Normal";
            this.BtnNormal.UseVisualStyleBackColor = true;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // BtnPoisson
            // 
            this.BtnPoisson.Location = new System.Drawing.Point(635, 272);
            this.BtnPoisson.Name = "BtnPoisson";
            this.BtnPoisson.Size = new System.Drawing.Size(251, 73);
            this.BtnPoisson.TabIndex = 4;
            this.BtnPoisson.Text = "Poisson";
            this.BtnPoisson.UseVisualStyleBackColor = true;
            this.BtnPoisson.Click += new System.EventHandler(this.BtnPoisson_Click);
            // 
            // BtnExp
            // 
            this.BtnExp.Location = new System.Drawing.Point(934, 272);
            this.BtnExp.Name = "BtnExp";
            this.BtnExp.Size = new System.Drawing.Size(251, 73);
            this.BtnExp.TabIndex = 5;
            this.BtnExp.Text = "Exponencial";
            this.BtnExp.UseVisualStyleBackColor = true;
            // 
            // PantallaSeleccionModo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 448);
            this.Controls.Add(this.BtnExp);
            this.Controls.Add(this.BtnPoisson);
            this.Controls.Add(this.BtnNormal);
            this.Controls.Add(this.BtnUniforme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PantallaSeleccionModo";
            this.Text = "PantallaSelecciónModo";
            this.Load += new System.EventHandler(this.PantallaSeleccionModo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUniforme;
        private System.Windows.Forms.Button BtnNormal;
        private System.Windows.Forms.Button BtnPoisson;
        private System.Windows.Forms.Button BtnExp;
    }
}