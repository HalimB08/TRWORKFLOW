namespace TRWORKFLOW.UserLogin
{
    partial class UserLoginForm
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtUserName = new MaterialSkin.Controls.MaterialTextBox();
            lblUserName = new MaterialSkin.Controls.MaterialLabel();
            lblUserPassword = new MaterialSkin.Controls.MaterialLabel();
            txtUserPassword = new MaterialSkin.Controls.MaterialTextBox();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            btnRegister = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(336, 82);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(102, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Kullanıcı Girişi";
            // 
            // txtUserName
            // 
            txtUserName.AnimateReadOnly = false;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Depth = 0;
            txtUserName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserName.LeadingIcon = null;
            txtUserName.Location = new Point(211, 132);
            txtUserName.MaxLength = 50;
            txtUserName.MouseState = MaterialSkin.MouseState.OUT;
            txtUserName.Multiline = false;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(341, 50);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "";
            txtUserName.TrailingIcon = null;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Depth = 0;
            lblUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserName.Location = new Point(84, 134);
            lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(93, 19);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Kullanıcı Adı:";
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.Depth = 0;
            lblUserPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserPassword.Location = new Point(84, 190);
            lblUserPassword.MouseState = MaterialSkin.MouseState.HOVER;
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(115, 19);
            lblUserPassword.TabIndex = 4;
            lblUserPassword.Text = "Kullanıcı Şifresi:";
            // 
            // txtUserPassword
            // 
            txtUserPassword.AnimateReadOnly = false;
            txtUserPassword.BorderStyle = BorderStyle.None;
            txtUserPassword.Depth = 0;
            txtUserPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserPassword.LeadingIcon = null;
            txtUserPassword.Location = new Point(211, 188);
            txtUserPassword.MaxLength = 50;
            txtUserPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtUserPassword.Multiline = false;
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Password = true;
            txtUserPassword.Size = new Size(341, 50);
            txtUserPassword.TabIndex = 3;
            txtUserPassword.Text = "";
            txtUserPassword.TrailingIcon = null;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(394, 256);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(158, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = false;
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegister.Depth = 0;
            btnRegister.HighEmphasis = true;
            btnRegister.Icon = null;
            btnRegister.Location = new Point(7, 405);
            btnRegister.Margin = new Padding(4, 6, 4, 6);
            btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.NoAccentTextColor = Color.Empty;
            btnRegister.Size = new Size(170, 36);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegister.UseAccentColor = false;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblUserPassword);
            Controls.Add(txtUserPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(materialLabel1);
            Name = "UserLoginForm";
            Text = "TRWORKFLOW - Kullanıcı Giriş Ekranı";
            Load += UserLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtUserName;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private MaterialSkin.Controls.MaterialLabel lblUserPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUserPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnRegister;
    }
}