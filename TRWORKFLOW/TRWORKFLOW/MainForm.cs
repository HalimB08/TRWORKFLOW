using TRWORKFLOW.Core.Concrete;
using TRWORKFLOW.UserLogin;
namespace TRWORKFLOW
{
    public partial class MainForm : Form
    {
        public static string UserName = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserLoginOperations userLoginOperations = new UserLoginOperations();
            if (userLoginOperations.IsItFirstTimeLogin())
            {
                FirstLoginForm firstLoginForm = new FirstLoginForm();
                firstLoginForm.Show();
            }
            if (!userLoginOperations.IsItFirstTimeLogin())
            {
                UserLoginForm userLoginForm = new UserLoginForm();
                userLoginForm.Show();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}