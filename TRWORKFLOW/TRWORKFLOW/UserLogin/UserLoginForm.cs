using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using TRWORKFLOW.Utils.Concrete;

namespace TRWORKFLOW.UserLogin
{
    public partial class UserLoginForm : MaterialForm
    {
        CultureInfo turkishCulture = new CultureInfo("tr-TR");
        Constants constants = new Constants();
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FirstLoginForm firstLoginForm = new FirstLoginForm();
            firstLoginForm.ShowDialog();
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
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperText(txtUserName, e, false, false);
        }
    }
}
