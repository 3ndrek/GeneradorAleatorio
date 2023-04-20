namespace GeneradorAleatorio.Pantallas
{
    partial class PantallaHistogramaChi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DataGVCHI = new System.Windows.Forms.DataGridView();
            this.LimInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreqObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreqEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Histograma1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCalculado = new System.Windows.Forms.Label();
            this.lblTabulado = new System.Windows.Forms.Label();
            this.lblValorCalculado = new System.Windows.Forms.Label();
            this.lblValorTabulado = new System.Windows.Forms.Label();
            this.lblCalculadoo = new System.Windows.Forms.Label();
            this.lblAceptacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVCHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histograma1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGVCHI
            // 
            this.DataGVCHI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVCHI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LimInf,
            this.LimSup,
            this.FreqObs,
            this.FreqEsp});
            this.DataGVCHI.Location = new System.Drawing.Point(22, 12);
            this.DataGVCHI.Name = "DataGVCHI";
            this.DataGVCHI.Size = new System.Drawing.Size(763, 265);
            this.DataGVCHI.TabIndex = 0;
            // 
            // LimInf
            // 
            this.LimInf.HeaderText = "Limite Inferior";
            this.LimInf.Name = "LimInf";
            this.LimInf.ReadOnly = true;
            this.LimInf.Width = 190;
            // 
            // LimSup
            // 
            this.LimSup.HeaderText = "Limite Superior";
            this.LimSup.Name = "LimSup";
            this.LimSup.ReadOnly = true;
            this.LimSup.Width = 190;
            // 
            // FreqObs
            // 
            this.FreqObs.HeaderText = "Frecuencia Observada";
            this.FreqObs.Name = "FreqObs";
            this.FreqObs.ReadOnly = true;
            this.FreqObs.Width = 190;
            // 
            // FreqEsp
            // 
            this.FreqEsp.HeaderText = "Frecuencia Esperada";
            this.FreqEsp.Name = "FreqEsp";
            this.FreqEsp.ReadOnly = true;
            this.FreqEsp.Width = 150;
            // 
            // Histograma1
            // 
            this.Histograma1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.Histograma1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Histograma1.Legends.Add(legend2);
            this.Histograma1.Location = new System.Drawing.Point(12, 314);
            this.Histograma1.Name = "Histograma1";
            this.Histograma1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Intervalos";
            this.Histograma1.Series.Add(series2);
            this.Histograma1.Size = new System.Drawing.Size(1336, 372);
            this.Histograma1.TabIndex = 1;
            this.Histograma1.Text = "Histograma de los datos generados";
            // 
            // lblCalculado
            // 
            this.lblCalculado.AutoSize = true;
            this.lblCalculado.Location = new System.Drawing.Point(914, 45);
            this.lblCalculado.Name = "lblCalculado";
            this.lblCalculado.Size = new System.Drawing.Size(0, 13);
            this.lblCalculado.TabIndex = 2;
            // 
            // lblTabulado
            // 
            this.lblTabulado.AutoSize = true;
            this.lblTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabulado.Location = new System.Drawing.Point(914, 91);
            this.lblTabulado.Name = "lblTabulado";
            this.lblTabulado.Size = new System.Drawing.Size(104, 17);
            this.lblTabulado.TabIndex = 3;
            this.lblTabulado.Text = "Valor tabulado:";
            // 
            // lblValorCalculado
            // 
            this.lblValorCalculado.AutoSize = true;
            this.lblValorCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCalculado.Location = new System.Drawing.Point(1083, 45);
            this.lblValorCalculado.Name = "lblValorCalculado";
            this.lblValorCalculado.Size = new System.Drawing.Size(52, 17);
            this.lblValorCalculado.TabIndex = 4;
            this.lblValorCalculado.Text = "label3";
            // 
            // lblValorTabulado
            // 
            this.lblValorTabulado.AutoSize = true;
            this.lblValorTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTabulado.Location = new System.Drawing.Point(1083, 91);
            this.lblValorTabulado.Name = "lblValorTabulado";
            this.lblValorTabulado.Size = new System.Drawing.Size(52, 17);
            this.lblValorTabulado.TabIndex = 5;
            this.lblValorTabulado.Text = "label4";
            // 
            // lblCalculadoo
            // 
            this.lblCalculadoo.AutoSize = true;
            this.lblCalculadoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadoo.Location = new System.Drawing.Point(914, 41);
            this.lblCalculadoo.Name = "lblCalculadoo";
            this.lblCalculadoo.Size = new System.Drawing.Size(109, 17);
            this.lblCalculadoo.TabIndex = 6;
            this.lblCalculadoo.Text = "Valor calculado:";
            // 
            // lblAceptacion
            // 
            this.lblAceptacion.AutoSize = true;
            this.lblAceptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceptacion.Location = new System.Drawing.Point(829, 133);
            this.lblAceptacion.Name = "lblAceptacion";
            this.lblAceptacion.Size = new System.Drawing.Size(52, 17);
            this.lblAceptacion.TabIndex = 7;
            this.lblAceptacion.Text = "label5";
            // 
            // PantallaHistogramaChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 718);
            this.Controls.Add(this.lblAceptacion);
            this.Controls.Add(this.lblCalculadoo);
            this.Controls.Add(this.lblValorTabulado);
            this.Controls.Add(this.lblValorCalculado);
            this.Controls.Add(this.lblTabulado);
            this.Controls.Add(this.lblCalculado);
            this.Controls.Add(this.Histograma1);
            this.Controls.Add(this.DataGVCHI);
            this.Name = "PantallaHistogramaChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de Histograma y Prueba";
            this.Load += new System.EventHandler(this.PantallaHistogramaChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histograma1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGVCHI;
        private System.Windows.Forms.DataVisualization.Charting.Chart Histograma1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreqObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreqEsp;
        private System.Windows.Forms.Label lblCalculado;
        private System.Windows.Forms.Label lblTabulado;
        private System.Windows.Forms.Label lblValorCalculado;
        private System.Windows.Forms.Label lblValorTabulado;
        private System.Windows.Forms.Label lblCalculadoo;
        private System.Windows.Forms.Label lblAceptacion;
    }
}