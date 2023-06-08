namespace mainApp
{
    public partial class LoginCotrol : UserControl
    {
        public UserClass User;
        public List<UserClass> UsersList;
        public LoginCotrol()
        {
            InitializeComponent();
        }
        public void Init(UserClass userClass,List<UserClass>userList = null)
        {
            this.User = userClass;
            this.UsersList = userList;
        }
        public void LoginControl_Load(object sender, EventArgs e)
        {
            calendarLogin.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012".
            calendarLogin.CustomFormat = " dd MM yyyy";
            passwordInput.UseSystemPasswordChar = true;
        }

        public void passwordEye_Click(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = !passwordInput.UseSystemPasswordChar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uName = usernameInput.Text;
            string uPassword = passwordInput.Text;

            if (!User.IsLoggedIn && VerifyCredentials(uName, uPassword)) User.IsLoggedIn = true;
            else if (User.IsLoggedIn) User.IsLoggedIn = false;
            else
            {
                User.IsLoggedIn = false; // Wrong credentials ... :display message 
                loginError.Visible = true;
            }
            if (User.IsLoggedIn)
            {
                btnLogin.Text = "LogOut";
                loginError.Visible = false;
            }
            else
                btnLogin.Text = "LogIn";

        }
        bool VerifyCredentials(string uName,string uPassword)
        {
            foreach(UserClass user in UsersList)
                if (user.UserName == uName && user.USerPassword == uPassword)
                    return true;
            return false;
        }

        private void WelcomeText_Click(object sender, EventArgs e)
        {

        }

        private void usernameText_Click(object sender, EventArgs e)
        {

        }
    }
}
