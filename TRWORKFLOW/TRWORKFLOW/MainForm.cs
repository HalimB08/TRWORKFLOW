using TRWORKFLOW.Core.Concrete;

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
        }
    }
}