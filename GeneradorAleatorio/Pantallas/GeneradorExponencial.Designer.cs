namespace GeneradorAleatorio.Pantallas
{
    partial class GeneradorExponencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneradorExponencial));
            this.mediaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedia = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.txtCantValores = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.SuspendLayout();
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
            this.mediaLabel.Location = new System.Drawing.Point(206, 183);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(361, 32);
            this.mediaLabel.TabIndex = 6;
            this.mediaLabel.Text = "Ingrese el valor de la media";
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
            this.label1.Location = new System.Drawing.Point(206, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese el tamaño de la muestra";
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
            this.BtnGenerar.Location = new System.Drawing.Point(212, 431);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(678, 68);
            this.BtnGenerar.TabIndex = 3;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(360, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Distribución Exponencial";
            // 
            // txtMedia
            // 
            this.txtMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.txtMedia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMedia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMedia.BorderSize = 2;
            this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.ForeColor = System.Drawing.Color.White;
            this.txtMedia.Location = new System.Drawing.Point(644, 183);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedia.Multiline = false;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Padding = new System.Windows.Forms.Padding(7);
            this.txtMedia.PasswordChar = false;
            this.txtMedia.Size = new System.Drawing.Size(246, 39);
            this.txtMedia.TabIndex = 1;
            this.txtMedia.Texts = "";
            this.txtMedia.UnderlinedStyle = false;
            // 
            // txtCantValores
            // 
            this.txtCantValores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.txtCantValores.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCantValores.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCantValores.BorderSize = 2;
            this.txtCantValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantValores.ForeColor = System.Drawing.Color.White;
            this.txtCantValores.Location = new System.Drawing.Point(644, 295);
            this.txtCantValores.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantValores.Multiline = false;
            this.txtCantValores.Name = "txtCantValores";
            this.txtCantValores.Padding = new System.Windows.Forms.Padding(7);
            this.txtCantValores.PasswordChar = false;
            this.txtCantValores.Size = new System.Drawing.Size(246, 39);
            this.txtCantValores.TabIndex = 10;
            this.txtCantValores.Texts = "";
            this.txtCantValores.UnderlinedStyle = false;
            // 
            // GeneradorExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1104, 755);
            this.Controls.Add(this.txtCantValores);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mediaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeneradorExponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Exponencial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneradorExponencial_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label label3;
        private PruebaInput txtMedia;
        private PruebaInput txtCantValores;
    }
}