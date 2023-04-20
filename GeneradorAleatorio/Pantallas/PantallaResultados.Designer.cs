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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaResultados));
            this.DvgArreglo = new System.Windows.Forms.DataGridView();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIntervalos = new GeneradorAleatorio.Pantallas.PruebaInput();
            ((System.ComponentModel.ISupportInitialize)(this.DvgArreglo)).BeginInit();
            this.SuspendLayout();
            // 
            // DvgArreglo
            // 
            this.DvgArreglo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DvgArreglo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgArreglo.Location = new System.Drawing.Point(40, 49);
            this.DvgArreglo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DvgArreglo.Name = "DvgArreglo";
            this.DvgArreglo.RowHeadersWidth = 62;
            this.DvgArreglo.Size = new System.Drawing.Size(360, 983);
            this.DvgArreglo.TabIndex = 0;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.Coral;
            this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGenerar.Location = new System.Drawing.Point(507, 188);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(297, 68);
            this.BtnGenerar.TabIndex = 3;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(442, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad de intervalos a graficar:";
            // 
            // TxtIntervalos
            // 
            this.TxtIntervalos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.TxtIntervalos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtIntervalos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtIntervalos.BorderSize = 2;
            this.TxtIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntervalos.ForeColor = System.Drawing.Color.White;
            this.TxtIntervalos.Location = new System.Drawing.Point(535, 125);
            this.TxtIntervalos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIntervalos.Multiline = false;
            this.TxtIntervalos.Name = "TxtIntervalos";
            this.TxtIntervalos.Padding = new System.Windows.Forms.Padding(7);
            this.TxtIntervalos.PasswordChar = false;
            this.TxtIntervalos.Size = new System.Drawing.Size(246, 39);
            this.TxtIntervalos.TabIndex = 1;
            this.TxtIntervalos.Texts = "";
            this.TxtIntervalos.UnderlinedStyle = false;
            // 
            // PantallaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(918, 1050);
            this.Controls.Add(this.TxtIntervalos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.DvgArreglo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de Resultados";
            this.Load += new System.EventHandler(this.PantallaResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgArreglo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgArreglo;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label label1;
        private PruebaInput TxtIntervalos;
    }
}