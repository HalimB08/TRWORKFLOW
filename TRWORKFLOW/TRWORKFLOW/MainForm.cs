using TRWORKFLOW.Core.Concrete;
using TRWORKFLOW.UserLogin;
namespace TRWORKFLOW
{
    public partial class MainForm : Form
    {
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
                firstLoginForm.ShowDialog();
            }
        }
    }
}