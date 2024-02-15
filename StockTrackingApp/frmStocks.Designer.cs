namespace StockTrackingApp
{
    partial class frmStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStocks));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGV_stockList = new System.Windows.Forms.DataGridView();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_newProductAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_stockList)).BeginInit();
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
            // dataGV_stockList
            // 
            this.dataGV_stockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_stockList.Location = new System.Drawing.Point(27, 90);
            this.dataGV_stockList.Name = "dataGV_stockList";
            this.dataGV_stockList.RowHeadersWidth = 51;
            this.dataGV_stockList.RowTemplate.Height = 24;
            this.dataGV_stockList.Size = new System.Drawing.Size(852, 490);
            this.dataGV_stockList.TabIndex = 1;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.SeaShell;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_return.Location = new System.Drawing.Point(697, 607);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(182, 37);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "Ana Sayfaya Dön";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_newProductAdd
            // 
            this.btn_newProductAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_newProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_newProductAdd.Location = new System.Drawing.Point(27, 607);
            this.btn_newProductAdd.Name = "btn_newProductAdd";
            this.btn_newProductAdd.Size = new System.Drawing.Size(182, 37);
            this.btn_newProductAdd.TabIndex = 3;
            this.btn_newProductAdd.Text = "Yeni Ürün Ekle";
            this.btn_newProductAdd.UseVisualStyleBackColor = false;
            this.btn_newProductAdd.Click += new System.EventHandler(this.btn_newProductAdd_Click);
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(905, 677);
            this.Controls.Add(this.btn_newProductAdd);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.dataGV_stockList);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.frmStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_stockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGV_stockList;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_newProductAdd;
    }
}