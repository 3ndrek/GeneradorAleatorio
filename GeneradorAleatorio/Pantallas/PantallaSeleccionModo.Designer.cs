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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaSeleccionModo));
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUniforme = new System.Windows.Forms.Button();
            this.BtnNormal = new System.Windows.Forms.Button();
            this.BtnPoisson = new System.Windows.Forms.Button();
            this.BtnExp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(410, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(654, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la distribución a generar";
            // 
            // BtnUniforme
            // 
            this.BtnUniforme.BackColor = System.Drawing.Color.Coral;
            this.BtnUniforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUniforme.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUniforme.Location = new System.Drawing.Point(32, 272);
            this.BtnUniforme.Name = "BtnUniforme";
            this.BtnUniforme.Size = new System.Drawing.Size(251, 73);
            this.BtnUniforme.TabIndex = 2;
            this.BtnUniforme.Text = "Uniforme";
            this.BtnUniforme.UseVisualStyleBackColor = false;
            this.BtnUniforme.Click += new System.EventHandler(this.BtnUniforme_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.BackColor = System.Drawing.Color.Coral;
            this.BtnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNormal.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnNormal.Location = new System.Drawing.Point(336, 272);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(251, 73);
            this.BtnNormal.TabIndex = 3;
            this.BtnNormal.Text = "Normal";
            this.BtnNormal.UseVisualStyleBackColor = false;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // BtnPoisson
            // 
            this.BtnPoisson.BackColor = System.Drawing.Color.Coral;
            this.BtnPoisson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPoisson.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPoisson.Location = new System.Drawing.Point(635, 272);
            this.BtnPoisson.Name = "BtnPoisson";
            this.BtnPoisson.Size = new System.Drawing.Size(251, 73);
            this.BtnPoisson.TabIndex = 4;
            this.BtnPoisson.Text = "Poisson";
            this.BtnPoisson.UseVisualStyleBackColor = false;
            this.BtnPoisson.Click += new System.EventHandler(this.BtnPoisson_Click);
            // 
            // BtnExp
            // 
            this.BtnExp.BackColor = System.Drawing.Color.Coral;
            this.BtnExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExp.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnExp.Location = new System.Drawing.Point(934, 272);
            this.BtnExp.Name = "BtnExp";
            this.BtnExp.Size = new System.Drawing.Size(251, 73);
            this.BtnExp.TabIndex = 5;
            this.BtnExp.Text = "Exponencial";
            this.BtnExp.UseVisualStyleBackColor = false;
            this.BtnExp.Click += new System.EventHandler(this.BtnExp_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(558, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 47);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bienvenido";
            // 
            // PantallaSeleccionModo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1219, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnExp);
            this.Controls.Add(this.BtnPoisson);
            this.Controls.Add(this.BtnNormal);
            this.Controls.Add(this.BtnUniforme);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PantallaSeleccionModo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Selección Modo";
            this.Load += new System.EventHandler(this.PantallaSeleccionModo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUniforme;
        private System.Windows.Forms.Button BtnNormal;
        private System.Windows.Forms.Button BtnPoisson;
        private System.Windows.Forms.Button BtnExp;
        private System.Windows.Forms.Label label3;
    }
}