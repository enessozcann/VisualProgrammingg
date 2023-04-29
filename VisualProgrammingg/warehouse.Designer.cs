
namespace VisualProgrammingg
{
    partial class warehouse
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
            this.warehouseDtaGridView = new System.Windows.Forms.DataGridView();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.MaxStockLabel = new System.Windows.Forms.Label();
            this.IdLabelProduct = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.ManageWarehouseLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.phoneNumLabell = new System.Windows.Forms.TextBox();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDtaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // warehouseDtaGridView
            // 
            this.warehouseDtaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.warehouseDtaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseDtaGridView.Location = new System.Drawing.Point(347, 100);
            this.warehouseDtaGridView.Name = "warehouseDtaGridView";
            this.warehouseDtaGridView.Size = new System.Drawing.Size(566, 221);
            this.warehouseDtaGridView.TabIndex = 18;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(121, 206);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(203, 20);
            this.AdressTextBox.TabIndex = 12;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(121, 166);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(203, 20);
            this.stockTextBox.TabIndex = 13;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(121, 101);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(203, 20);
            this.IdTextBox.TabIndex = 16;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(121, 133);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(203, 20);
            this.CountryTextBox.TabIndex = 17;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(254, 298);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(70, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(60, 298);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(70, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(57, 209);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(42, 13);
            this.AdressLabel.TabIndex = 4;
            this.AdressLabel.Text = "Adress:";
            // 
            // MaxStockLabel
            // 
            this.MaxStockLabel.AutoSize = true;
            this.MaxStockLabel.Location = new System.Drawing.Point(38, 169);
            this.MaxStockLabel.Name = "MaxStockLabel";
            this.MaxStockLabel.Size = new System.Drawing.Size(61, 13);
            this.MaxStockLabel.TabIndex = 5;
            this.MaxStockLabel.Text = "Max Stock:";
            // 
            // IdLabelProduct
            // 
            this.IdLabelProduct.AutoSize = true;
            this.IdLabelProduct.Location = new System.Drawing.Point(78, 104);
            this.IdLabelProduct.Name = "IdLabelProduct";
            this.IdLabelProduct.Size = new System.Drawing.Size(21, 13);
            this.IdLabelProduct.TabIndex = 8;
            this.IdLabelProduct.Text = "ID:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(53, 133);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 13);
            this.CountryLabel.TabIndex = 9;
            this.CountryLabel.Text = "Country:";
            // 
            // ManageWarehouseLabel
            // 
            this.ManageWarehouseLabel.AutoSize = true;
            this.ManageWarehouseLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ManageWarehouseLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ManageWarehouseLabel.Location = new System.Drawing.Point(283, 21);
            this.ManageWarehouseLabel.Name = "ManageWarehouseLabel";
            this.ManageWarehouseLabel.Size = new System.Drawing.Size(305, 32);
            this.ManageWarehouseLabel.TabIndex = 19;
            this.ManageWarehouseLabel.Text = "MANAGE WAREHOUSE";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.exitButton.Location = new System.Drawing.Point(854, 21);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 32);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // phoneNumLabell
            // 
            this.phoneNumLabell.Location = new System.Drawing.Point(121, 243);
            this.phoneNumLabell.Name = "phoneNumLabell";
            this.phoneNumLabell.Size = new System.Drawing.Size(203, 20);
            this.phoneNumLabell.TabIndex = 12;
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Location = new System.Drawing.Point(18, 246);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumLabel.TabIndex = 4;
            this.phoneNumLabel.Text = "Phone Number:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(153, 298);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 384);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ManageWarehouseLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.warehouseDtaGridView);
            this.Controls.Add(this.phoneNumLabell);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.MaxStockLabel);
            this.Controls.Add(this.IdLabelProduct);
            this.Controls.Add(this.CountryLabel);
            this.Name = "warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDtaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView warehouseDtaGridView;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label MaxStockLabel;
        private System.Windows.Forms.Label IdLabelProduct;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label ManageWarehouseLabel;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.TextBox phoneNumLabell;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Button clearButton;
    }
}