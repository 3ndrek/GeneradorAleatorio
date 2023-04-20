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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneadorUniforme));
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mediaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LimSup = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.LimInf = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.CantNum = new GeneradorAleatorio.Pantallas.PruebaInput();
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
            this.label3.Location = new System.Drawing.Point(364, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Distribución Uniforme";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerar.BackColor = System.Drawing.Color.Coral;
            this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGenerar.Location = new System.Drawing.Point(208, 535);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(685, 68);
            this.BtnGenerar.TabIndex = 12;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
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
            this.label4.Location = new System.Drawing.Point(207, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingrese el valor del límite inferior";
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
            this.mediaLabel.Location = new System.Drawing.Point(202, 177);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(438, 32);
            this.mediaLabel.TabIndex = 13;
            this.mediaLabel.Text = "Ingrese el valor del límite superior";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(207, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese el tamaño de la muestra";
            // 
            // LimSup
            // 
            this.LimSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.LimSup.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.LimSup.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LimSup.BorderSize = 2;
            this.LimSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimSup.ForeColor = System.Drawing.Color.White;
            this.LimSup.Location = new System.Drawing.Point(647, 177);
            this.LimSup.Margin = new System.Windows.Forms.Padding(4);
            this.LimSup.Multiline = false;
            this.LimSup.Name = "LimSup";
            this.LimSup.Padding = new System.Windows.Forms.Padding(7);
            this.LimSup.PasswordChar = false;
            this.LimSup.Size = new System.Drawing.Size(246, 39);
            this.LimSup.TabIndex = 17;
            this.LimSup.Texts = "";
            this.LimSup.UnderlinedStyle = false;
            // 
            // LimInf
            // 
            this.LimInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.LimInf.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.LimInf.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LimInf.BorderSize = 2;
            this.LimInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimInf.ForeColor = System.Drawing.Color.White;
            this.LimInf.Location = new System.Drawing.Point(646, 303);
            this.LimInf.Margin = new System.Windows.Forms.Padding(4);
            this.LimInf.Multiline = false;
            this.LimInf.Name = "LimInf";
            this.LimInf.Padding = new System.Windows.Forms.Padding(7);
            this.LimInf.PasswordChar = false;
            this.LimInf.Size = new System.Drawing.Size(246, 39);
            this.LimInf.TabIndex = 18;
            this.LimInf.Texts = "";
            this.LimInf.UnderlinedStyle = false;
            // 
            // CantNum
            // 
            this.CantNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.CantNum.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CantNum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CantNum.BorderSize = 2;
            this.CantNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantNum.ForeColor = System.Drawing.Color.White;
            this.CantNum.Location = new System.Drawing.Point(646, 425);
            this.CantNum.Margin = new System.Windows.Forms.Padding(4);
            this.CantNum.Multiline = false;
            this.CantNum.Name = "CantNum";
            this.CantNum.Padding = new System.Windows.Forms.Padding(7);
            this.CantNum.PasswordChar = false;
            this.CantNum.Size = new System.Drawing.Size(246, 39);
            this.CantNum.TabIndex = 19;
            this.CantNum.Texts = "";
            this.CantNum.UnderlinedStyle = false;
            // 
            // GeneadorUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1104, 755);
            this.Controls.Add(this.CantNum);
            this.Controls.Add(this.LimInf);
            this.Controls.Add(this.LimSup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mediaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneadorUniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Uniforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneadorUniforme_FormClosing);
            this.Load += new System.EventHandler(this.GeneadorUniforme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.Label label1;
        private PruebaInput LimSup;
        private PruebaInput LimInf;
        private PruebaInput CantNum;
    }
}