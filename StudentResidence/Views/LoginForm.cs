using System.Windows.Forms;

namespace StudentResidence.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
        }

        // свойства для получения элементов управления
        public Label MyLabel
        {
            get { return lblStatus; }
            set { lblStatus = value; }
        }

        public TextBox GetLogin
        {
            get
            {
                return tbLogin;
            }
        }

        public TextBox GetPassword
        {
            get
            {
                return tbPassword;
            }
        }

        public Button GetButton
        {
            get
            {
                return btnLogin;
            }
        }
    }
}
