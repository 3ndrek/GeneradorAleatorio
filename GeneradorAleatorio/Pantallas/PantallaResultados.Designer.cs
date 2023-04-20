namespace GeneradorAleatorio.Pantallas
{
    partial class PantallaResultados
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
            this.DvgArreglo = new System.Windows.Forms.DataGridView();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.TxtIntervalos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DvgArreglo)).BeginInit();
            this.SuspendLayout();
            // 
            // DvgArreglo
            // 
            this.DvgArreglo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgArreglo.Location = new System.Drawing.Point(27, 32);
            this.DvgArreglo.Name = "DvgArreglo";
            this.DvgArreglo.Size = new System.Drawing.Size(240, 627);
            this.DvgArreglo.TabIndex = 0;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.Coral;
            this.BtnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGenerar.Location = new System.Drawing.Point(338, 122);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(198, 44);
            this.BtnGenerar.TabIndex = 3;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // TxtIntervalos
            // 
            this.TxtIntervalos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntervalos.Location = new System.Drawing.Point(359, 80);
            this.TxtIntervalos.Name = "TxtIntervalos";
            this.TxtIntervalos.Size = new System.Drawing.Size(163, 26);
            this.TxtIntervalos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(295, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad de intervalos a graficar:";
            // 
            // PantallaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIntervalos);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.DvgArreglo);
            this.Name = "PantallaResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaResultados";
            this.Load += new System.EventHandler(this.PantallaResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgArreglo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgArreglo;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.TextBox TxtIntervalos;
        private System.Windows.Forms.Label label1;
    }
}