namespace Estanoco.MA.Winforms.UserManager
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string fullName = txtfullname.Text;
            string userName = txtusername.Text;
            string password = txtpassword.Text;

            if(string.IsNullOrWhiteSpace(fullName)
                || string.IsNullOrWhiteSpace(userName)
                || string.IsNullOrWhiteSpace(password))
                {
                MessageBox.Show("Boy mali mo!","IncorrectInput",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                User userToSave = new User();
                userToSave.Username = userName;
                userToSave.Fullname = fullName;
                userToSave.Password = password;

                UserRepository repository = new UserRepository();
                bool isSaved = repository.Add(userToSave);

                if (isSaved)
                {
                    MessageBox.Show("Boy na saved na!", "Successful",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtfullname.Clear();
                    txtusername.Clear();
                    txtpassword.Clear();
                    

                }
            }
        }
    }
}
