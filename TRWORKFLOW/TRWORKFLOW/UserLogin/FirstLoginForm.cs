using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TRWORKFLOW.Utils;
using TRWORKFLOW.Utils.Concrete;
using System.Globalization;
using TRWORKFLOW.Core.Concrete;
using TRWORKFLOW.Entities.Concrete;

namespace TRWORKFLOW.UserLogin
{
    public partial class FirstLoginForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        Constants constants = new Constants();
        CultureInfo turkishCulture = new CultureInfo("tr-TR");
        public bool formClose = false;
        public FirstLoginForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }
        public void UpperText(MaterialTextBox tbx, KeyPressEventArgs e, bool isTurkishCharacterEnable = true, bool isUnwantedCharactersEnable = true)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !isUnwantedCharactersEnable)
            {
                e.Handled = true;
            }
            if (!isTurkishCharacterEnable && constants.turkishAlphabet.Contains(turkishCulture.TextInfo.ToUpper(e.KeyChar.ToString())))
            {
                e.Handled = true;
                return;
            }
            if (Char.IsLower(e.KeyChar))
            {
                string convertedChar = turkishCulture.TextInfo.ToUpper(e.KeyChar.ToString());
                tbx.SelectedText = convertedChar;
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperText(txtFirstName, e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperText(txtLastName, e);
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperText(txtUserName, e, false, false);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.UserName = txtUserName.Text;
                user.BirthDate = DateTime.ParseExact(txtBirthDate.Text, "dd.MM.yyyy", CultureInfo.GetCultureInfo("tr-TR"));
                user.Authority = 0;
                user.IsActive = true;
                user.Gender = cmbGender.Text;
                user.Password = txtPassword.Text;
                user.Mail = txtMail.Text;
                UserRegisterOperations userRegisterOperations = new UserRegisterOperations();
                userRegisterOperations.RegisterAdminUser(user);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt gerçekleştirirken bir sorun meydana geldi.");
                return;
            }
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Show();
            formClose = true;
            this.Close();

        }

        private void FirstLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formClose)
            {
                return;
            }
            Application.Exit();
        }
    }
}
