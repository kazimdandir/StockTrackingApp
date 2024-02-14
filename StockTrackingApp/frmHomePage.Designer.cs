namespace StockTrackingApp
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.btn_addStock = new System.Windows.Forms.Button();
            this.btn_stocks = new System.Windows.Forms.Button();
            this.btn_updateStock = new System.Windows.Forms.Button();
            this.btn_closeApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addStock
            // 
            this.btn_addStock.BackColor = System.Drawing.Color.Lime;
            this.btn_addStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addStock.Location = new System.Drawing.Point(40, 35);
            this.btn_addStock.Name = "btn_addStock";
            this.btn_addStock.Size = new System.Drawing.Size(230, 112);
            this.btn_addStock.TabIndex = 0;
            this.btn_addStock.Text = "STOK EKLE";
            this.btn_addStock.UseVisualStyleBackColor = false;
            this.btn_addStock.Click += new System.EventHandler(this.btn_addStock_Click);
            // 
            // btn_stocks
            // 
            this.btn_stocks.BackColor = System.Drawing.Color.Gold;
            this.btn_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_stocks.Location = new System.Drawing.Point(322, 35);
            this.btn_stocks.Name = "btn_stocks";
            this.btn_stocks.Size = new System.Drawing.Size(230, 112);
            this.btn_stocks.TabIndex = 1;
            this.btn_stocks.Text = "STOKLAR";
            this.btn_stocks.UseVisualStyleBackColor = false;
            this.btn_stocks.Click += new System.EventHandler(this.btn_stocks_Click);
            // 
            // btn_updateStock
            // 
            this.btn_updateStock.BackColor = System.Drawing.Color.Coral;
            this.btn_updateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_updateStock.Location = new System.Drawing.Point(40, 188);
            this.btn_updateStock.Name = "btn_updateStock";
            this.btn_updateStock.Size = new System.Drawing.Size(230, 112);
            this.btn_updateStock.TabIndex = 2;
            this.btn_updateStock.Text = "STOK GÜNCELLE";
            this.btn_updateStock.UseVisualStyleBackColor = false;
            this.btn_updateStock.Click += new System.EventHandler(this.btn_updateStock_Click);
            // 
            // btn_closeApp
            // 
            this.btn_closeApp.BackColor = System.Drawing.Color.Red;
            this.btn_closeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_closeApp.Location = new System.Drawing.Point(322, 188);
            this.btn_closeApp.Name = "btn_closeApp";
            this.btn_closeApp.Size = new System.Drawing.Size(230, 112);
            this.btn_closeApp.TabIndex = 3;
            this.btn_closeApp.Text = "UYGULAMAYI KAPAT";
            this.btn_closeApp.UseVisualStyleBackColor = false;
            this.btn_closeApp.Click += new System.EventHandler(this.btn_closeApp_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 347);
            this.Controls.Add(this.btn_closeApp);
            this.Controls.Add(this.btn_updateStock);
            this.Controls.Add(this.btn_stocks);
            this.Controls.Add(this.btn_addStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addStock;
        private System.Windows.Forms.Button btn_updateStock;
        private System.Windows.Forms.Button btn_closeApp;
        private System.Windows.Forms.Button btn_stocks;
    }
}

