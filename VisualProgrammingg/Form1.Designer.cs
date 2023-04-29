
namespace VisualProgrammingg
{
    partial class LOGIN
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.LoginLable = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PassworddLabel = new System.Windows.Forms.Label();
            this.RegisterrLabel = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBoxx = new System.Windows.Forms.TextBox();
            this.girisEkranıResim = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.roleLabell = new System.Windows.Forms.Label();
            this.roleTextBoxxx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.girisEkranıResim)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginLable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginLable.Location = new System.Drawing.Point(388, 155);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(101, 32);
            this.LoginLable.TabIndex = 0;
            this.LoginLable.Text = "LOGIN";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(223, 267);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(74, 13);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "USER NAME:";
            // 
            // PassworddLabel
            // 
            this.PassworddLabel.AutoSize = true;
            this.PassworddLabel.Location = new System.Drawing.Point(224, 320);
            this.PassworddLabel.Name = "PassworddLabel";
            this.PassworddLabel.Size = new System.Drawing.Size(73, 13);
            this.PassworddLabel.TabIndex = 1;
            this.PassworddLabel.Text = "PASSWORD:";
            // 
            // RegisterrLabel
            // 
            this.RegisterrLabel.Location = new System.Drawing.Point(394, 422);
            this.RegisterrLabel.Name = "RegisterrLabel";
            this.RegisterrLabel.Size = new System.Drawing.Size(75, 23);
            this.RegisterrLabel.TabIndex = 2;
            this.RegisterrLabel.Text = "REGISTER";
            this.RegisterrLabel.UseVisualStyleBackColor = true;
            this.RegisterrLabel.Click += new System.EventHandler(this.RegisterrLabel_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(394, 371);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(327, 267);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(212, 20);
            this.UserNameTextBox.TabIndex = 4;
            // 
            // PasswordTextBoxx
            // 
            this.PasswordTextBoxx.Location = new System.Drawing.Point(327, 317);
            this.PasswordTextBoxx.Name = "PasswordTextBoxx";
            this.PasswordTextBoxx.Size = new System.Drawing.Size(212, 20);
            this.PasswordTextBoxx.TabIndex = 4;
            // 
            // girisEkranıResim
            // 
            this.girisEkranıResim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisEkranıResim.BackgroundImage")));
            this.girisEkranıResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisEkranıResim.Location = new System.Drawing.Point(208, 12);
            this.girisEkranıResim.Name = "girisEkranıResim";
            this.girisEkranıResim.Size = new System.Drawing.Size(444, 113);
            this.girisEkranıResim.TabIndex = 6;
            this.girisEkranıResim.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ExitButton.Location = new System.Drawing.Point(785, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 32);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // roleLabell
            // 
            this.roleLabell.AutoSize = true;
            this.roleLabell.Location = new System.Drawing.Point(258, 227);
            this.roleLabell.Name = "roleLabell";
            this.roleLabell.Size = new System.Drawing.Size(39, 13);
            this.roleLabell.TabIndex = 1;
            this.roleLabell.Text = "ROLE:";
            // 
            // roleTextBoxxx
            // 
            this.roleTextBoxxx.Location = new System.Drawing.Point(327, 224);
            this.roleTextBoxxx.Name = "roleTextBoxxx";
            this.roleTextBoxxx.Size = new System.Drawing.Size(212, 20);
            this.roleTextBoxxx.TabIndex = 4;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 538);
            this.Controls.Add(this.girisEkranıResim);
            this.Controls.Add(this.PasswordTextBoxx);
            this.Controls.Add(this.roleTextBoxxx);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterrLabel);
            this.Controls.Add(this.PassworddLabel);
            this.Controls.Add(this.roleLabell);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginLable);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.girisEkranıResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PassworddLabel;
        private System.Windows.Forms.Button RegisterrLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBoxx;
        private System.Windows.Forms.PictureBox girisEkranıResim;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label roleLabell;
        private System.Windows.Forms.TextBox roleTextBoxxx;
    }
}

