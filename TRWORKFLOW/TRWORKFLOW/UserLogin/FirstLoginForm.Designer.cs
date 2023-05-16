namespace TRWORKFLOW.UserLogin
{
    partial class FirstLoginForm
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
            txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            lblFirstName = new MaterialSkin.Controls.MaterialLabel();
            txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            lblLastName = new MaterialSkin.Controls.MaterialLabel();
            txtMail = new MaterialSkin.Controls.MaterialTextBox();
            lblMail = new MaterialSkin.Controls.MaterialLabel();
            lblUserName = new MaterialSkin.Controls.MaterialLabel();
            txtUserName = new MaterialSkin.Controls.MaterialTextBox();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            lblPassword = new MaterialSkin.Controls.MaterialLabel();
            txtBirthDate = new MaterialSkin.Controls.MaterialTextBox();
            lblBirthDate = new MaterialSkin.Controls.MaterialLabel();
            cmbGender = new MaterialSkin.Controls.MaterialComboBox();
            btnRegister = new MaterialSkin.Controls.MaterialButton();
            lblGender = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(390, 79);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(172, 30);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Admin Kayıt Ekranı";
            // 
            // txtFirstName
            // 
            txtFirstName.AnimateReadOnly = false;
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Depth = 0;
            txtFirstName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFirstName.LeadingIcon = null;
            txtFirstName.Location = new Point(372, 131);
            txtFirstName.MaxLength = 50;
            txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            txtFirstName.Multiline = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(240, 50);
            txtFirstName.TabIndex = 0;
            txtFirstName.Text = "";
            txtFirstName.TrailingIcon = null;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Depth = 0;
            lblFirstName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFirstName.Location = new Point(240, 133);
            lblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(78, 19);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "Admin Adı:";
            // 
            // txtLastName
            // 
            txtLastName.AnimateReadOnly = false;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Depth = 0;
            txtLastName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLastName.LeadingIcon = null;
            txtLastName.Location = new Point(372, 187);
            txtLastName.MaxLength = 50;
            txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(240, 50);
            txtLastName.TabIndex = 1;
            txtLastName.Text = "";
            txtLastName.TrailingIcon = null;
            txtLastName.KeyPress += txtLastName_KeyPress;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Depth = 0;
            lblLastName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLastName.Location = new Point(240, 189);
            lblLastName.MouseState = MaterialSkin.MouseState.HOVER;
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 19);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Admin Soyadı:";
            // 
            // txtMail
            // 
            txtMail.AnimateReadOnly = false;
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Depth = 0;
            txtMail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMail.LeadingIcon = null;
            txtMail.Location = new Point(372, 243);
            txtMail.MaxLength = 50;
            txtMail.MouseState = MaterialSkin.MouseState.OUT;
            txtMail.Multiline = false;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(240, 50);
            txtMail.TabIndex = 2;
            txtMail.Text = "";
            txtMail.TrailingIcon = null;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Depth = 0;
            lblMail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMail.Location = new Point(240, 245);
            lblMail.MouseState = MaterialSkin.MouseState.HOVER;
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(86, 19);
            lblMail.TabIndex = 6;
            lblMail.Text = "Admin Mail:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Depth = 0;
            lblUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserName.Location = new Point(240, 304);
            lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(104, 19);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Admin Kimliği:";
            // 
            // txtUserName
            // 
            txtUserName.AnimateReadOnly = false;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Depth = 0;
            txtUserName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserName.LeadingIcon = null;
            txtUserName.Location = new Point(372, 302);
            txtUserName.MaxLength = 50;
            txtUserName.MouseState = MaterialSkin.MouseState.OUT;
            txtUserName.Multiline = false;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(240, 50);
            txtUserName.TabIndex = 3;
            txtUserName.Text = "";
            txtUserName.TrailingIcon = null;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(372, 358);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(240, 50);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Depth = 0;
            lblPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPassword.Location = new Point(240, 360);
            lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 19);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Admin Şifresi:";
            // 
            // txtBirthDate
            // 
            txtBirthDate.AnimateReadOnly = false;
            txtBirthDate.BorderStyle = BorderStyle.None;
            txtBirthDate.Depth = 0;
            txtBirthDate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBirthDate.LeadingIcon = null;
            txtBirthDate.Location = new Point(372, 414);
            txtBirthDate.MaxLength = 50;
            txtBirthDate.MouseState = MaterialSkin.MouseState.OUT;
            txtBirthDate.Multiline = false;
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(240, 50);
            txtBirthDate.TabIndex = 5;
            txtBirthDate.Text = "";
            txtBirthDate.TrailingIcon = null;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Depth = 0;
            lblBirthDate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBirthDate.Location = new Point(240, 416);
            lblBirthDate.MouseState = MaterialSkin.MouseState.HOVER;
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(83, 19);
            lblBirthDate.TabIndex = 12;
            lblBirthDate.Text = "Doğum Yılı:";
            // 
            // cmbGender
            // 
            cmbGender.AutoResize = false;
            cmbGender.BackColor = Color.FromArgb(255, 255, 255);
            cmbGender.Depth = 0;
            cmbGender.DrawMode = DrawMode.OwnerDrawVariable;
            cmbGender.DropDownHeight = 174;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.DropDownWidth = 121;
            cmbGender.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbGender.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.IntegralHeight = false;
            cmbGender.ItemHeight = 43;
            cmbGender.Items.AddRange(new object[] { "Fark etmez", "Erkek", "Kadın" });
            cmbGender.Location = new Point(372, 470);
            cmbGender.MaxDropDownItems = 4;
            cmbGender.MouseState = MaterialSkin.MouseState.OUT;
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(240, 49);
            cmbGender.StartIndex = 0;
            cmbGender.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegister.Depth = 0;
            btnRegister.HighEmphasis = true;
            btnRegister.Icon = null;
            btnRegister.Location = new Point(528, 528);
            btnRegister.Margin = new Padding(4, 6, 4, 6);
            btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.NoAccentTextColor = Color.Empty;
            btnRegister.Size = new Size(84, 36);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegister.UseAccentColor = false;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Depth = 0;
            lblGender.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblGender.Location = new Point(240, 474);
            lblGender.MouseState = MaterialSkin.MouseState.HOVER;
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(61, 19);
            lblGender.TabIndex = 13;
            lblGender.Text = "Cinsiyet:";
            // 
            // FirstLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 595);
            Controls.Add(lblGender);
            Controls.Add(btnRegister);
            Controls.Add(cmbGender);
            Controls.Add(lblBirthDate);
            Controls.Add(txtBirthDate);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblMail);
            Controls.Add(txtMail);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(materialLabel1);
            Name = "FirstLoginForm";
            Text = "TRWORKFLOW - Admin Kayıt Ekranı";
            FormClosed += FirstLoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialLabel lblFirstName;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialLabel lblLastName;
        private MaterialSkin.Controls.MaterialTextBox txtMail;
        private MaterialSkin.Controls.MaterialLabel lblMail;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private MaterialSkin.Controls.MaterialTextBox txtUserName;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialTextBox txtBirthDate;
        private MaterialSkin.Controls.MaterialLabel lblBirthDate;
        private MaterialSkin.Controls.MaterialComboBox cmbGender;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialLabel lblGender;
    }
}