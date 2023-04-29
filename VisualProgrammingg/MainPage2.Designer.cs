
namespace VisualProgrammingg
{
    partial class FactoryPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactoryPage));
            this.nameLabelProduct = new System.Windows.Forms.Label();
            this.WeightLabelProduct = new System.Windows.Forms.Label();
            this.SalesLabelProduct = new System.Windows.Forms.Label();
            this.DateLabelProduct = new System.Windows.Forms.Label();
            this.IdLabelProduct = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ManageProductsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.SalesTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.visualProgrammingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualProgrammingDataSet = new VisualProgrammingg.visualProgrammingDataSet();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addWarehouseButton = new System.Windows.Forms.Button();
            this.whouseTextBox = new System.Windows.Forms.TextBox();
            this.whouseLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.sendProductLabel = new System.Windows.Forms.Label();
            this.productAcceptTextbox = new System.Windows.Forms.TextBox();
            this.amountTextBoxx = new System.Windows.Forms.TextBox();
            this.sendNameLabel = new System.Windows.Forms.Label();
            this.sendAmountLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.clearrbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabelProduct
            // 
            this.nameLabelProduct.AutoSize = true;
            this.nameLabelProduct.Location = new System.Drawing.Point(56, 128);
            this.nameLabelProduct.Name = "nameLabelProduct";
            this.nameLabelProduct.Size = new System.Drawing.Size(38, 13);
            this.nameLabelProduct.TabIndex = 0;
            this.nameLabelProduct.Text = "Name:";
            // 
            // WeightLabelProduct
            // 
            this.WeightLabelProduct.AutoSize = true;
            this.WeightLabelProduct.Location = new System.Drawing.Point(50, 195);
            this.WeightLabelProduct.Name = "WeightLabelProduct";
            this.WeightLabelProduct.Size = new System.Drawing.Size(44, 13);
            this.WeightLabelProduct.TabIndex = 0;
            this.WeightLabelProduct.Text = "Weight:";
            // 
            // SalesLabelProduct
            // 
            this.SalesLabelProduct.AutoSize = true;
            this.SalesLabelProduct.Location = new System.Drawing.Point(31, 228);
            this.SalesLabelProduct.Name = "SalesLabelProduct";
            this.SalesLabelProduct.Size = new System.Drawing.Size(63, 13);
            this.SalesLabelProduct.TabIndex = 0;
            this.SalesLabelProduct.Text = "Sales Price:";
            // 
            // DateLabelProduct
            // 
            this.DateLabelProduct.AutoSize = true;
            this.DateLabelProduct.Location = new System.Drawing.Point(7, 160);
            this.DateLabelProduct.Name = "DateLabelProduct";
            this.DateLabelProduct.Size = new System.Drawing.Size(87, 13);
            this.DateLabelProduct.TabIndex = 0;
            this.DateLabelProduct.Text = "Production Date:";
            // 
            // IdLabelProduct
            // 
            this.IdLabelProduct.AutoSize = true;
            this.IdLabelProduct.Location = new System.Drawing.Point(73, 92);
            this.IdLabelProduct.Name = "IdLabelProduct";
            this.IdLabelProduct.Size = new System.Drawing.Size(21, 13);
            this.IdLabelProduct.TabIndex = 0;
            this.IdLabelProduct.Text = "ID:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(39, 338);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(70, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(223, 338);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(70, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ManageProductsLabel
            // 
            this.ManageProductsLabel.AutoSize = true;
            this.ManageProductsLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.ManageProductsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ManageProductsLabel.Location = new System.Drawing.Point(292, 12);
            this.ManageProductsLabel.Name = "ManageProductsLabel";
            this.ManageProductsLabel.Size = new System.Drawing.Size(360, 41);
            this.ManageProductsLabel.TabIndex = 0;
            this.ManageProductsLabel.Text = "MANAGE PRODUCTS";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.exitButton.Location = new System.Drawing.Point(826, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 32);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SalesTextBox
            // 
            this.SalesTextBox.Location = new System.Drawing.Point(100, 225);
            this.SalesTextBox.Name = "SalesTextBox";
            this.SalesTextBox.Size = new System.Drawing.Size(181, 20);
            this.SalesTextBox.TabIndex = 2;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(48, 263);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(46, 13);
            this.AmountLabel.TabIndex = 0;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(100, 260);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(181, 20);
            this.AmountTextBox.TabIndex = 2;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(310, 89);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(549, 272);
            this.productsDataGridView.TabIndex = 3;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // visualProgrammingDataSetBindingSource
            // 
            this.visualProgrammingDataSetBindingSource.DataSource = this.visualProgrammingDataSet;
            this.visualProgrammingDataSetBindingSource.Position = 0;
            // 
            // visualProgrammingDataSet
            // 
            this.visualProgrammingDataSet.DataSetName = "visualProgrammingDataSet";
            this.visualProgrammingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(100, 192);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(181, 20);
            this.WeightTextBox.TabIndex = 2;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(100, 157);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(181, 20);
            this.DateTextBox.TabIndex = 2;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(100, 89);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(181, 20);
            this.IdTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(181, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // addWarehouseButton
            // 
            this.addWarehouseButton.Location = new System.Drawing.Point(10, 13);
            this.addWarehouseButton.Name = "addWarehouseButton";
            this.addWarehouseButton.Size = new System.Drawing.Size(123, 40);
            this.addWarehouseButton.TabIndex = 4;
            this.addWarehouseButton.Text = "Add Warehouse";
            this.addWarehouseButton.UseVisualStyleBackColor = true;
            this.addWarehouseButton.Click += new System.EventHandler(this.addWarehouseButton_Click);
            // 
            // whouseTextBox
            // 
            this.whouseTextBox.Location = new System.Drawing.Point(100, 297);
            this.whouseTextBox.Name = "whouseTextBox";
            this.whouseTextBox.Size = new System.Drawing.Size(181, 20);
            this.whouseTextBox.TabIndex = 2;
            // 
            // whouseLabel
            // 
            this.whouseLabel.AutoSize = true;
            this.whouseLabel.Location = new System.Drawing.Point(29, 300);
            this.whouseLabel.Name = "whouseLabel";
            this.whouseLabel.Size = new System.Drawing.Size(65, 13);
            this.whouseLabel.TabIndex = 0;
            this.whouseLabel.Text = "Warehouse:";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(310, 477);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // sendProductLabel
            // 
            this.sendProductLabel.AutoSize = true;
            this.sendProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendProductLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sendProductLabel.Location = new System.Drawing.Point(18, 383);
            this.sendProductLabel.Name = "sendProductLabel";
            this.sendProductLabel.Size = new System.Drawing.Size(249, 39);
            this.sendProductLabel.TabIndex = 6;
            this.sendProductLabel.Text = "Send Product:";
            // 
            // productAcceptTextbox
            // 
            this.productAcceptTextbox.Location = new System.Drawing.Point(142, 441);
            this.productAcceptTextbox.Name = "productAcceptTextbox";
            this.productAcceptTextbox.Size = new System.Drawing.Size(125, 20);
            this.productAcceptTextbox.TabIndex = 2;
            // 
            // amountTextBoxx
            // 
            this.amountTextBoxx.Location = new System.Drawing.Point(142, 479);
            this.amountTextBoxx.Name = "amountTextBoxx";
            this.amountTextBoxx.Size = new System.Drawing.Size(125, 20);
            this.amountTextBoxx.TabIndex = 2;
            // 
            // sendNameLabel
            // 
            this.sendNameLabel.AutoSize = true;
            this.sendNameLabel.Location = new System.Drawing.Point(31, 444);
            this.sendNameLabel.Name = "sendNameLabel";
            this.sendNameLabel.Size = new System.Drawing.Size(78, 13);
            this.sendNameLabel.TabIndex = 0;
            this.sendNameLabel.Text = "Product Name:";
            // 
            // sendAmountLabel
            // 
            this.sendAmountLabel.AutoSize = true;
            this.sendAmountLabel.Location = new System.Drawing.Point(63, 482);
            this.sendAmountLabel.Name = "sendAmountLabel";
            this.sendAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.sendAmountLabel.TabIndex = 0;
            this.sendAmountLabel.Text = "Amount:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(310, 439);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // clearrbutton
            // 
            this.clearrbutton.Location = new System.Drawing.Point(127, 338);
            this.clearrbutton.Name = "clearrbutton";
            this.clearrbutton.Size = new System.Drawing.Size(75, 23);
            this.clearrbutton.TabIndex = 8;
            this.clearrbutton.Text = "CLEAR";
            this.clearrbutton.UseVisualStyleBackColor = true;
            this.clearrbutton.Click += new System.EventHandler(this.clearrbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(429, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 130);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FactoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearrbutton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.sendProductLabel);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.addWarehouseButton);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.whouseTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.SalesTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.amountTextBoxx);
            this.Controls.Add(this.productAcceptTextbox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.sendAmountLabel);
            this.Controls.Add(this.sendNameLabel);
            this.Controls.Add(this.whouseLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.SalesLabelProduct);
            this.Controls.Add(this.WeightLabelProduct);
            this.Controls.Add(this.DateLabelProduct);
            this.Controls.Add(this.IdLabelProduct);
            this.Controls.Add(this.ManageProductsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameLabelProduct);
            this.Name = "FactoryPage";
            this.Text = "FACTORY";
            this.Load += new System.EventHandler(this.FactoryPage_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabelProduct;
        private System.Windows.Forms.Label WeightLabelProduct;
        private System.Windows.Forms.Label SalesLabelProduct;
        private System.Windows.Forms.Label DateLabelProduct;
        private System.Windows.Forms.Label IdLabelProduct;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label ManageProductsLabel;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.TextBox SalesTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource visualProgrammingDataSetBindingSource;
        private visualProgrammingDataSet visualProgrammingDataSet;
        private System.Windows.Forms.Button addWarehouseButton;
        private System.Windows.Forms.TextBox whouseTextBox;
        private System.Windows.Forms.Label whouseLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label sendProductLabel;
        private System.Windows.Forms.TextBox productAcceptTextbox;
        private System.Windows.Forms.TextBox amountTextBoxx;
        private System.Windows.Forms.Label sendNameLabel;
        private System.Windows.Forms.Label sendAmountLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button clearrbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}