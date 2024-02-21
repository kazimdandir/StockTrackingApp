namespace StockTrackingApp
{
    partial class frmAddProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProductPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_productCode = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_productCount = new System.Windows.Forms.TextBox();
            this.txt_productPurchasePrice = new System.Windows.Forms.TextBox();
            this.txt_productSalePrice = new System.Windows.Forms.TextBox();
            this.btn_addStock = new System.Windows.Forms.Button();
            this.btn_clearSelected = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(138, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOK EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(98, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Kodu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(98, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Adeti :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Alış Fiyatı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün Satış Fiyatı :";
            // 
            // txt_productCode
            // 
            this.txt_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_productCode.Location = new System.Drawing.Point(217, 110);
            this.txt_productCode.Name = "txt_productCode";
            this.txt_productCode.Size = new System.Drawing.Size(183, 27);
            this.txt_productCode.TabIndex = 1;
            // 
            // txt_productName
            // 
            this.txt_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_productName.Location = new System.Drawing.Point(217, 167);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(183, 27);
            this.txt_productName.TabIndex = 2;
            this.txt_productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productName_KeyPress);
            // 
            // txt_productCount
            // 
            this.txt_productCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_productCount.Location = new System.Drawing.Point(217, 223);
            this.txt_productCount.Name = "txt_productCount";
            this.txt_productCount.Size = new System.Drawing.Size(183, 27);
            this.txt_productCount.TabIndex = 3;
            this.txt_productCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productCount_KeyPress);
            // 
            // txt_productPurchasePrice
            // 
            this.txt_productPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_productPurchasePrice.Location = new System.Drawing.Point(217, 276);
            this.txt_productPurchasePrice.Name = "txt_productPurchasePrice";
            this.txt_productPurchasePrice.Size = new System.Drawing.Size(183, 27);
            this.txt_productPurchasePrice.TabIndex = 4;
            this.txt_productPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productPurchasePrice_KeyPress);
            // 
            // txt_productSalePrice
            // 
            this.txt_productSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_productSalePrice.Location = new System.Drawing.Point(217, 325);
            this.txt_productSalePrice.Name = "txt_productSalePrice";
            this.txt_productSalePrice.Size = new System.Drawing.Size(183, 27);
            this.txt_productSalePrice.TabIndex = 5;
            this.txt_productSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productSalePrice_KeyPress);
            // 
            // btn_addStock
            // 
            this.btn_addStock.BackColor = System.Drawing.Color.Lime;
            this.btn_addStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addStock.Location = new System.Drawing.Point(57, 378);
            this.btn_addStock.Name = "btn_addStock";
            this.btn_addStock.Size = new System.Drawing.Size(160, 57);
            this.btn_addStock.TabIndex = 6;
            this.btn_addStock.Text = "Stok Ekle";
            this.btn_addStock.UseVisualStyleBackColor = false;
            this.btn_addStock.Click += new System.EventHandler(this.btn_addStock_Click);
            // 
            // btn_clearSelected
            // 
            this.btn_clearSelected.BackColor = System.Drawing.Color.IndianRed;
            this.btn_clearSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clearSelected.Location = new System.Drawing.Point(240, 379);
            this.btn_clearSelected.Name = "btn_clearSelected";
            this.btn_clearSelected.Size = new System.Drawing.Size(160, 57);
            this.btn_clearSelected.TabIndex = 7;
            this.btn_clearSelected.Text = "Seçenekleri \r\nTemizle";
            this.btn_clearSelected.UseVisualStyleBackColor = false;
            this.btn_clearSelected.Click += new System.EventHandler(this.btn_clearSelected_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(54, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Not:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(94, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fiyatlarda virgül kullanınız!";
            // 
            // frmAddProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(460, 526);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clearSelected);
            this.Controls.Add(this.btn_addStock);
            this.Controls.Add(this.txt_productSalePrice);
            this.Controls.Add(this.txt_productPurchasePrice);
            this.Controls.Add(this.txt_productCount);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.txt_productCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddProductPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_productCode;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_productCount;
        private System.Windows.Forms.TextBox txt_productPurchasePrice;
        private System.Windows.Forms.TextBox txt_productSalePrice;
        private System.Windows.Forms.Button btn_addStock;
        private System.Windows.Forms.Button btn_clearSelected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}