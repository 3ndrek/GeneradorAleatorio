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
            this.mediaInput = new System.Windows.Forms.TextBox();
            this.mediaLabel = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMuller = new System.Windows.Forms.Button();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.desviaLabel = new System.Windows.Forms.Label();
            this.desviaInput = new System.Windows.Forms.TextBox();
            this.labelCant = new System.Windows.Forms.Label();
            this.inputCant = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mediaInput
            // 
            this.mediaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaInput.Location = new System.Drawing.Point(574, 230);
            this.mediaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediaInput.Name = "mediaInput";
            this.mediaInput.Size = new System.Drawing.Size(216, 30);
            this.mediaInput.TabIndex = 0;
            this.mediaInput.Visible = false;
            // 
            // mediaLabel
            // 
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.BackColor = System.Drawing.Color.Transparent;
            this.mediaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaLabel.ForeColor = System.Drawing.Color.DimGray;
            this.mediaLabel.Location = new System.Drawing.Point(183, 231);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(192, 29);
            this.mediaLabel.TabIndex = 2;
            this.mediaLabel.Text = "Ingrese la media";
            this.mediaLabel.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Coral;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Transparent;
            this.btnGenerar.Location = new System.Drawing.Point(188, 415);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(602, 54);
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
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(342, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione el método";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnMuller
            // 
            this.btnMuller.AccessibleName = "btnMuller";
            this.btnMuller.BackColor = System.Drawing.Color.Coral;
            this.btnMuller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuller.ForeColor = System.Drawing.Color.Transparent;
            this.btnMuller.Location = new System.Drawing.Point(186, 93);
            this.btnMuller.Name = "btnMuller";
            this.btnMuller.Size = new System.Drawing.Size(216, 59);
            this.btnMuller.TabIndex = 6;
            this.btnMuller.Text = " Box-Muller";
            this.btnMuller.UseVisualStyleBackColor = false;
            this.btnMuller.Click += new System.EventHandler(this.btnMuller_Click);
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.AccessibleName = "btnConvolucion";
            this.btnConvolucion.BackColor = System.Drawing.Color.Coral;
            this.btnConvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvolucion.ForeColor = System.Drawing.Color.Transparent;
            this.btnConvolucion.Location = new System.Drawing.Point(574, 93);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(216, 59);
            this.btnConvolucion.TabIndex = 7;
            this.btnConvolucion.Text = "Convolución";
            this.btnConvolucion.UseVisualStyleBackColor = false;
            this.btnConvolucion.Click += new System.EventHandler(this.btnConvolucion_Click);
            // 
            // desviaLabel
            // 
            this.desviaLabel.AutoSize = true;
            this.desviaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desviaLabel.ForeColor = System.Drawing.Color.DimGray;
            this.desviaLabel.Location = new System.Drawing.Point(181, 291);
            this.desviaLabel.Name = "desviaLabel";
            this.desviaLabel.Size = new System.Drawing.Size(339, 29);
            this.desviaLabel.TabIndex = 8;
            this.desviaLabel.Text = "Ingrese la desviacion estandar";
            this.desviaLabel.Visible = false;
            // 
            // desviaInput
            // 
            this.desviaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desviaInput.Location = new System.Drawing.Point(574, 291);
            this.desviaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desviaInput.Name = "desviaInput";
            this.desviaInput.Size = new System.Drawing.Size(216, 30);
            this.desviaInput.TabIndex = 9;
            this.desviaInput.Visible = false;
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.ForeColor = System.Drawing.Color.DimGray;
            this.labelCant.Location = new System.Drawing.Point(181, 348);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(334, 29);
            this.labelCant.TabIndex = 10;
            this.labelCant.Text = "Ingrese la cantidad de valores";
            this.labelCant.Visible = false;
            // 
            // inputCant
            // 
            this.inputCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCant.Location = new System.Drawing.Point(574, 348);
            this.inputCant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCant.Name = "inputCant";
            this.inputCant.Size = new System.Drawing.Size(216, 30);
            this.inputCant.TabIndex = 11;
            this.inputCant.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleName = "btnConvolucion";
            this.btnReset.BackColor = System.Drawing.Color.Coral;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Transparent;
            this.btnReset.Location = new System.Drawing.Point(574, 506);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(216, 59);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GeneradorNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 604);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.inputCant);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.desviaInput);
            this.Controls.Add(this.desviaLabel);
            this.Controls.Add(this.btnConvolucion);
            this.Controls.Add(this.btnMuller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.mediaLabel);
            this.Controls.Add(this.mediaInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GeneradorNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneradorNormal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneradorNormal_FormClosing);
            this.Load += new System.EventHandler(this.GeneradorNormal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mediaInput;
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMuller;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Label desviaLabel;
        private System.Windows.Forms.TextBox desviaInput;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.TextBox inputCant;
        private System.Windows.Forms.Button btnReset;
    }
}