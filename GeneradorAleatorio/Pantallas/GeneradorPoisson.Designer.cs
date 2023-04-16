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
            this.btnPoisson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPoisson
            // 
            this.btnPoisson.Location = new System.Drawing.Point(414, 237);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(93, 36);
            this.btnPoisson.TabIndex = 0;
            this.btnPoisson.Text = "Generar";
            this.btnPoisson.UseVisualStyleBackColor = true;
            this.btnPoisson.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lambda:";
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(219, 143);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(121, 20);
            this.txtMuestra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Muestra:";
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(219, 50);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(121, 20);
            this.txtLambda.TabIndex = 5;
            // 
            // GeneradorPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 285);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMuestra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPoisson);
            this.Name = "GeneradorPoisson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneradorPoisson_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLambda;
    }
}