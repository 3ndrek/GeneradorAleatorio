namespace GeneradorAleatorio.Pantallas
{
    partial class GeneradorNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneradorNormal));
            this.mediaLabel = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMuller = new System.Windows.Forms.Button();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.desviaLabel = new System.Windows.Forms.Label();
            this.labelCant = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.mediaInput = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.desviaInput = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.inputCant = new GeneradorAleatorio.Pantallas.PruebaInput();
            this.SuspendLayout();
            // 
            // mediaLabel
            // 
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.BackColor = System.Drawing.Color.Transparent;
            this.mediaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaLabel.ForeColor = System.Drawing.Color.Silver;
            this.mediaLabel.Location = new System.Drawing.Point(206, 289);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(223, 32);
            this.mediaLabel.TabIndex = 2;
            this.mediaLabel.Text = "Ingrese la media";
            this.mediaLabel.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Coral;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Transparent;
            this.btnGenerar.Location = new System.Drawing.Point(212, 518);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(678, 68);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Visible = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(384, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione el método";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnMuller
            // 
            this.btnMuller.AccessibleName = "btnMuller";
            this.btnMuller.BackColor = System.Drawing.Color.Coral;
            this.btnMuller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuller.ForeColor = System.Drawing.Color.Transparent;
            this.btnMuller.Location = new System.Drawing.Point(210, 117);
            this.btnMuller.Name = "btnMuller";
            this.btnMuller.Size = new System.Drawing.Size(243, 74);
            this.btnMuller.TabIndex = 6;
            this.btnMuller.Text = " Box-Muller";
            this.btnMuller.UseVisualStyleBackColor = false;
            this.btnMuller.Click += new System.EventHandler(this.btnMuller_Click);
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.AccessibleName = "btnConvolucion";
            this.btnConvolucion.BackColor = System.Drawing.Color.Coral;
            this.btnConvolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvolucion.ForeColor = System.Drawing.Color.Transparent;
            this.btnConvolucion.Location = new System.Drawing.Point(645, 117);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(243, 74);
            this.btnConvolucion.TabIndex = 7;
            this.btnConvolucion.Text = "Convolución";
            this.btnConvolucion.UseVisualStyleBackColor = false;
            this.btnConvolucion.Click += new System.EventHandler(this.btnConvolucion_Click);
            // 
            // desviaLabel
            // 
            this.desviaLabel.AutoSize = true;
            this.desviaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desviaLabel.ForeColor = System.Drawing.Color.Silver;
            this.desviaLabel.Location = new System.Drawing.Point(204, 363);
            this.desviaLabel.Name = "desviaLabel";
            this.desviaLabel.Size = new System.Drawing.Size(399, 32);
            this.desviaLabel.TabIndex = 8;
            this.desviaLabel.Text = "Ingrese la desviacion estandar";
            this.desviaLabel.Visible = false;
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.ForeColor = System.Drawing.Color.Silver;
            this.labelCant.Location = new System.Drawing.Point(204, 435);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(392, 32);
            this.labelCant.TabIndex = 10;
            this.labelCant.Text = "Ingrese la cantidad de valores";
            this.labelCant.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleName = "btnConvolucion";
            this.btnReset.BackColor = System.Drawing.Color.Coral;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Transparent;
            this.btnReset.Location = new System.Drawing.Point(645, 632);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(243, 74);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mediaInput
            // 
            this.mediaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.mediaInput.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.mediaInput.BorderFocusColor = System.Drawing.Color.HotPink;
            this.mediaInput.BorderSize = 2;
            this.mediaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaInput.ForeColor = System.Drawing.Color.Black;
            this.mediaInput.Location = new System.Drawing.Point(642, 282);
            this.mediaInput.Margin = new System.Windows.Forms.Padding(4);
            this.mediaInput.Multiline = false;
            this.mediaInput.Name = "mediaInput";
            this.mediaInput.Padding = new System.Windows.Forms.Padding(7);
            this.mediaInput.PasswordChar = false;
            this.mediaInput.Size = new System.Drawing.Size(246, 39);
            this.mediaInput.TabIndex = 1;
            this.mediaInput.Texts = "";
            this.mediaInput.UnderlinedStyle = false;
            this.mediaInput.Visible = false;
            // 
            // desviaInput
            // 
            this.desviaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.desviaInput.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.desviaInput.BorderFocusColor = System.Drawing.Color.HotPink;
            this.desviaInput.BorderSize = 2;
            this.desviaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desviaInput.ForeColor = System.Drawing.Color.Black;
            this.desviaInput.Location = new System.Drawing.Point(642, 356);
            this.desviaInput.Margin = new System.Windows.Forms.Padding(4);
            this.desviaInput.Multiline = false;
            this.desviaInput.Name = "desviaInput";
            this.desviaInput.Padding = new System.Windows.Forms.Padding(7);
            this.desviaInput.PasswordChar = false;
            this.desviaInput.Size = new System.Drawing.Size(246, 39);
            this.desviaInput.TabIndex = 2;
            this.desviaInput.Texts = "";
            this.desviaInput.UnderlinedStyle = false;
            this.desviaInput.Visible = false;
            // 
            // inputCant
            // 
            this.inputCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.inputCant.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.inputCant.BorderFocusColor = System.Drawing.Color.HotPink;
            this.inputCant.BorderSize = 2;
            this.inputCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCant.ForeColor = System.Drawing.Color.Black;
            this.inputCant.Location = new System.Drawing.Point(642, 435);
            this.inputCant.Margin = new System.Windows.Forms.Padding(4);
            this.inputCant.Multiline = false;
            this.inputCant.Name = "inputCant";
            this.inputCant.Padding = new System.Windows.Forms.Padding(7);
            this.inputCant.PasswordChar = false;
            this.inputCant.Size = new System.Drawing.Size(246, 39);
            this.inputCant.TabIndex = 3;
            this.inputCant.Texts = "";
            this.inputCant.UnderlinedStyle = false;
            this.inputCant.Visible = false;
            // 
            // GeneradorNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1104, 755);
            this.Controls.Add(this.inputCant);
            this.Controls.Add(this.desviaInput);
            this.Controls.Add(this.mediaInput);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.desviaLabel);
            this.Controls.Add(this.btnConvolucion);
            this.Controls.Add(this.btnMuller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.mediaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneradorNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Normal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneradorNormal_FormClosing);
            this.Load += new System.EventHandler(this.GeneradorNormal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMuller;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Label desviaLabel;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Button btnReset;
        private PruebaInput mediaInput;
        private PruebaInput desviaInput;
        private PruebaInput inputCant;
    }
}