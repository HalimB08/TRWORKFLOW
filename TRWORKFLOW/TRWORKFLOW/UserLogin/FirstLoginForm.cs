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

namespace TRWORKFLOW.UserLogin
{
    public partial class FirstLoginForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public FirstLoginForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }
        public void UpperText(MaterialTextBox tbx, KeyPressEventArgs e, bool UseableTurkishAlphabet = true)
        {

        }
        public bool DontUseTurkishAlhapeth(KeyPressEventArgs e)
        {
            char upperChar = Char.ToUpper(e.KeyChar);
            if (upperChar < 'A' || upperChar > 'Z')
            {
                e.Handled = true; // Karakter girişini engelle
                return false;
            }
            return true;
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
            UpperText(txtUserName, e, false);
        }
    }
}
