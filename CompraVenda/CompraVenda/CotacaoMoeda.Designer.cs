namespace CompraVenda
{
    partial class CotacaoMoeda
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMoeda = new System.Windows.Forms.ComboBox();
            this.btnCotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moeda: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbMoeda
            // 
            this.cmbMoeda.FormattingEnabled = true;
            this.cmbMoeda.Items.AddRange(new object[] {
            "Dólar Americano (venda)",
            "Dólar Americano (compra)",
            "Euro (venda)",
            "Euro (compra)",
            "Iene (venda)",
            "Iene (compra)",
            "Dólar Canadense (venda)",
            "Dólar Canadense (compra)"});
            this.cmbMoeda.Location = new System.Drawing.Point(64, 49);
            this.cmbMoeda.Name = "cmbMoeda";
            this.cmbMoeda.Size = new System.Drawing.Size(222, 21);
            this.cmbMoeda.TabIndex = 1;
            // 
            // btnCotar
            // 
            this.btnCotar.Location = new System.Drawing.Point(344, 49);
            this.btnCotar.Name = "btnCotar";
            this.btnCotar.Size = new System.Drawing.Size(75, 23);
            this.btnCotar.TabIndex = 2;
            this.btnCotar.Text = "COTAR";
            this.btnCotar.UseVisualStyleBackColor = true;
            this.btnCotar.Click += new System.EventHandler(this.btnCotar_Click);
            // 
            // CotacaoMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 152);
            this.Controls.Add(this.btnCotar);
            this.Controls.Add(this.cmbMoeda);
            this.Controls.Add(this.label1);
            this.Name = "CotacaoMoeda";
            this.Text = "Cotação Moeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMoeda;
        private System.Windows.Forms.Button btnCotar;
    }
}