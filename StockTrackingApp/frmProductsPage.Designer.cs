namespace StockTrackingApp
{
    partial class frmProductsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductsPage));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGV_productList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_productList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(353, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOK LİSTESİ";
            // 
            // dataGV_productList
            // 
            this.dataGV_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_productList.Location = new System.Drawing.Point(27, 90);
            this.dataGV_productList.Name = "dataGV_productList";
            this.dataGV_productList.RowHeadersWidth = 51;
            this.dataGV_productList.RowTemplate.Height = 24;
            this.dataGV_productList.Size = new System.Drawing.Size(852, 490);
            this.dataGV_productList.TabIndex = 1;
            // 
            // frmProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(903, 609);
            this.Controls.Add(this.dataGV_productList);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.frmStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_productList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGV_productList;
    }
}