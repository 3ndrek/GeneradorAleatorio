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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DataGVCHI = new System.Windows.Forms.DataGridView();
            this.LimInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreqObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreqEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Histograma1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.DataGVCHI.Location = new System.Drawing.Point(216, 12);
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
            chartArea1.Name = "ChartArea1";
            this.Histograma1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Histograma1.Legends.Add(legend1);
            this.Histograma1.Location = new System.Drawing.Point(83, 299);
            this.Histograma1.Name = "Histograma1";
            this.Histograma1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Intervalos";
            this.Histograma1.Series.Add(series1);
            this.Histograma1.Size = new System.Drawing.Size(1050, 365);
            this.Histograma1.TabIndex = 1;
            this.Histograma1.Text = "Histograma de los datos generados";
            // 
            // PantallaHistogramaChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 695);
            this.Controls.Add(this.Histograma1);
            this.Controls.Add(this.DataGVCHI);
            this.Name = "PantallaHistogramaChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaHistogramaChi";
            this.Load += new System.EventHandler(this.PantallaHistogramaChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histograma1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGVCHI;
        private System.Windows.Forms.DataVisualization.Charting.Chart Histograma1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreqObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreqEsp;
    }
}