namespace GeneradorAleatorio.Pantallas
{
    partial class GeneradorPoisson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneradorPoisson));
            this.label3 = new System.Windows.Forms.Label();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mediaLabel = new System.Windows.Forms.Label();
            this.txtLambda = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.txtMuestra = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(362, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Distribución Poisson";
            // 
            // btnPoisson
            // 
            this.btnPoisson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoisson.BackColor = System.Drawing.Color.Coral;
            this.btnPoisson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoisson.ForeColor = System.Drawing.Color.Transparent;
            this.btnPoisson.Location = new System.Drawing.Point(213, 449);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(678, 68);
            this.btnPoisson.TabIndex = 12;
            this.btnPoisson.Text = "Generar";
            this.btnPoisson.UseVisualStyleBackColor = false;
            this.btnPoisson.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(207, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingrese el tamaño de la muestra";
            // 
            // mediaLabel
            // 
            this.mediaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.BackColor = System.Drawing.Color.Transparent;
            this.mediaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaLabel.ForeColor = System.Drawing.Color.Silver;
            this.mediaLabel.Location = new System.Drawing.Point(207, 202);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(356, 32);
            this.mediaLabel.TabIndex = 13;
            this.mediaLabel.Text = "Ingrese el valor de Lambda";
            // 
            // txtLambda
            // 
            this.txtLambda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.txtLambda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLambda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLambda.BorderSize = 2;
            this.txtLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLambda.ForeColor = System.Drawing.Color.Black;
            this.txtLambda.Location = new System.Drawing.Point(646, 202);
            this.txtLambda.Margin = new System.Windows.Forms.Padding(4);
            this.txtLambda.Multiline = false;
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Padding = new System.Windows.Forms.Padding(7);
            this.txtLambda.PasswordChar = false;
            this.txtLambda.Size = new System.Drawing.Size(246, 39);
            this.txtLambda.TabIndex = 1;
            this.txtLambda.Texts = "";
            this.txtLambda.UnderlinedStyle = false;
            // 
            // txtMuestra
            // 
            this.txtMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.txtMuestra.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMuestra.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMuestra.BorderSize = 2;
            this.txtMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuestra.ForeColor = System.Drawing.Color.Black;
            this.txtMuestra.Location = new System.Drawing.Point(646, 307);
            this.txtMuestra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMuestra.Multiline = false;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Padding = new System.Windows.Forms.Padding(7);
            this.txtMuestra.PasswordChar = false;
            this.txtMuestra.Size = new System.Drawing.Size(246, 39);
            this.txtMuestra.TabIndex = 2;
            this.txtMuestra.Texts = "";
            this.txtMuestra.UnderlinedStyle = false;
            // 
            // GeneradorPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1104, 755);
            this.Controls.Add(this.txtMuestra);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPoisson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mediaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeneradorPoisson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Poisson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneradorPoisson_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mediaLabel;
        private PruebaInput txtLambda;
        private PruebaInput txtMuestra;
    }
}