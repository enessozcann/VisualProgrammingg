
namespace VisualProgrammingg
{
    partial class CustomerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPage));
            this.visualProgrammingDataSet = new VisualProgrammingg.visualProgrammingDataSet();
            this.visualProgrammingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FactoryNameLabel = new System.Windows.Forms.Label();
            this.FactoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.visualProgrammingDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ListelemeButonu = new System.Windows.Forms.Button();
            this.siparişLabel = new System.Windows.Forms.Label();
            this.siparişTextBoc = new System.Windows.Forms.TextBox();
            this.productsssDataGridView = new System.Windows.Forms.DataGridView();
            this.siparişButon = new System.Windows.Forms.Button();
            this.Productnamelabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.amounttTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.shopPorductsLabel = new System.Windows.Forms.Label();
            this.ExitButtonn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsssDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // visualProgrammingDataSet
            // 
            this.visualProgrammingDataSet.DataSetName = "visualProgrammingDataSet";
            this.visualProgrammingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visualProgrammingDataSetBindingSource
            // 
            this.visualProgrammingDataSetBindingSource.DataSource = this.visualProgrammingDataSet;
            this.visualProgrammingDataSetBindingSource.Position = 0;
            // 
            // FactoryNameLabel
            // 
            this.FactoryNameLabel.AutoSize = true;
            this.FactoryNameLabel.Location = new System.Drawing.Point(68, 95);
            this.FactoryNameLabel.Name = "FactoryNameLabel";
            this.FactoryNameLabel.Size = new System.Drawing.Size(94, 13);
            this.FactoryNameLabel.TabIndex = 6;
            this.FactoryNameLabel.Text = "FACTORY NAME:";
            // 
            // FactoryNameComboBox
            // 
            this.FactoryNameComboBox.FormattingEnabled = true;
            this.FactoryNameComboBox.Location = new System.Drawing.Point(188, 92);
            this.FactoryNameComboBox.Name = "FactoryNameComboBox";
            this.FactoryNameComboBox.Size = new System.Drawing.Size(403, 21);
            this.FactoryNameComboBox.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // visualProgrammingDataSetBindingSource1
            // 
            this.visualProgrammingDataSetBindingSource1.DataSource = this.visualProgrammingDataSet;
            this.visualProgrammingDataSetBindingSource1.Position = 0;
            // 
            // ListelemeButonu
            // 
            this.ListelemeButonu.Location = new System.Drawing.Point(351, 196);
            this.ListelemeButonu.Name = "ListelemeButonu";
            this.ListelemeButonu.Size = new System.Drawing.Size(75, 23);
            this.ListelemeButonu.TabIndex = 10;
            this.ListelemeButonu.Text = "LIST";
            this.ListelemeButonu.UseVisualStyleBackColor = true;
            this.ListelemeButonu.Click += new System.EventHandler(this.ListelemeButonu_Click);
            // 
            // siparişLabel
            // 
            this.siparişLabel.AutoSize = true;
            this.siparişLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparişLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.siparişLabel.Location = new System.Drawing.Point(30, 437);
            this.siparişLabel.Name = "siparişLabel";
            this.siparişLabel.Size = new System.Drawing.Size(99, 25);
            this.siparişLabel.TabIndex = 11;
            this.siparişLabel.Text = "ORDER:";
            // 
            // siparişTextBoc
            // 
            this.siparişTextBoc.Location = new System.Drawing.Point(138, 471);
            this.siparişTextBoc.Name = "siparişTextBoc";
            this.siparişTextBoc.Size = new System.Drawing.Size(144, 20);
            this.siparişTextBoc.TabIndex = 13;
            // 
            // productsssDataGridView
            // 
            this.productsssDataGridView.AllowUserToAddRows = false;
            this.productsssDataGridView.AllowUserToDeleteRows = false;
            this.productsssDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsssDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsssDataGridView.Location = new System.Drawing.Point(11, 235);
            this.productsssDataGridView.Name = "productsssDataGridView";
            this.productsssDataGridView.ReadOnly = true;
            this.productsssDataGridView.Size = new System.Drawing.Size(777, 188);
            this.productsssDataGridView.TabIndex = 14;
            // 
            // siparişButon
            // 
            this.siparişButon.Location = new System.Drawing.Point(298, 508);
            this.siparişButon.Name = "siparişButon";
            this.siparişButon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.siparişButon.Size = new System.Drawing.Size(75, 23);
            this.siparişButon.TabIndex = 15;
            this.siparişButon.Text = "ORDER";
            this.siparişButon.UseVisualStyleBackColor = true;
            this.siparişButon.Click += new System.EventHandler(this.siparişButon_Click);
            // 
            // Productnamelabel
            // 
            this.Productnamelabel.AutoSize = true;
            this.Productnamelabel.Location = new System.Drawing.Point(65, 163);
            this.Productnamelabel.Name = "Productnamelabel";
            this.Productnamelabel.Size = new System.Drawing.Size(97, 13);
            this.Productnamelabel.TabIndex = 16;
            this.Productnamelabel.Text = "PRODUCT NAME:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(188, 160);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(403, 20);
            this.filterTextBox.TabIndex = 17;
            // 
            // amounttTextBox
            // 
            this.amounttTextBox.Location = new System.Drawing.Point(138, 510);
            this.amounttTextBox.Name = "amounttTextBox";
            this.amounttTextBox.Size = new System.Drawing.Size(144, 20);
            this.amounttTextBox.TabIndex = 13;
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSize = true;
            this.NameTextBox.Location = new System.Drawing.Point(52, 474);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(77, 13);
            this.NameTextBox.TabIndex = 16;
            this.NameTextBox.Text = "PRODUCT ID:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.AutoSize = true;
            this.amountTextBox.Location = new System.Drawing.Point(16, 513);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(113, 13);
            this.amountTextBox.TabIndex = 16;
            this.amountTextBox.Text = "PRODUCT AMOUNT:";
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(298, 469);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 18;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // shopPorductsLabel
            // 
            this.shopPorductsLabel.AutoSize = true;
            this.shopPorductsLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shopPorductsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.shopPorductsLabel.Location = new System.Drawing.Point(230, 9);
            this.shopPorductsLabel.Name = "shopPorductsLabel";
            this.shopPorductsLabel.Size = new System.Drawing.Size(295, 41);
            this.shopPorductsLabel.TabIndex = 19;
            this.shopPorductsLabel.Text = "SHOP PRODUCTS";
            // 
            // ExitButtonn
            // 
            this.ExitButtonn.AutoSize = true;
            this.ExitButtonn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButtonn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ExitButtonn.Location = new System.Drawing.Point(753, 9);
            this.ExitButtonn.Name = "ExitButtonn";
            this.ExitButtonn.Size = new System.Drawing.Size(35, 36);
            this.ExitButtonn.TabIndex = 20;
            this.ExitButtonn.Text = "X";
            this.ExitButtonn.Click += new System.EventHandler(this.ExitButtonn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(418, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 114);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButtonn);
            this.Controls.Add(this.shopPorductsLabel);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Productnamelabel);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.siparişButon);
            this.Controls.Add(this.productsssDataGridView);
            this.Controls.Add(this.siparişLabel);
            this.Controls.Add(this.ListelemeButonu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FactoryNameComboBox);
            this.Controls.Add(this.FactoryNameLabel);
            this.Controls.Add(this.amounttTextBox);
            this.Controls.Add(this.siparişTextBoc);
            this.Name = "CustomerPage";
            this.Text = "CUSTOMER";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProgrammingDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsssDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private visualProgrammingDataSet visualProgrammingDataSet;
        private System.Windows.Forms.BindingSource visualProgrammingDataSetBindingSource;
        private System.Windows.Forms.Label FactoryNameLabel;
        private System.Windows.Forms.ComboBox FactoryNameComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource visualProgrammingDataSetBindingSource1;
        private System.Windows.Forms.Button ListelemeButonu;
        private System.Windows.Forms.Label siparişLabel;
        private System.Windows.Forms.TextBox siparişTextBoc;
        private System.Windows.Forms.DataGridView productsssDataGridView;
        private System.Windows.Forms.Button siparişButon;
        private System.Windows.Forms.Label Productnamelabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.TextBox amounttTextBox;
        private System.Windows.Forms.Label NameTextBox;
        private System.Windows.Forms.Label amountTextBox;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label shopPorductsLabel;
        private System.Windows.Forms.Label ExitButtonn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}