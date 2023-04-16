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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIntervalos = new System.Windows.Forms.TextBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de intervalos a graficar: ";
            // 
            // TxtIntervalos
            // 
            this.TxtIntervalos.Location = new System.Drawing.Point(344, 78);
            this.TxtIntervalos.Name = "TxtIntervalos";
            this.TxtIntervalos.Size = new System.Drawing.Size(177, 20);
            this.TxtIntervalos.TabIndex = 2;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(391, 116);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerar.TabIndex = 3;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // PantallaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 671);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.TxtIntervalos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DvgArreglo);
            this.Name = "PantallaResultados";
            this.Text = "PantallaResultados";
            this.Load += new System.EventHandler(this.PantallaResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgArreglo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgArreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIntervalos;
        private System.Windows.Forms.Button BtnGenerar;
    }
}