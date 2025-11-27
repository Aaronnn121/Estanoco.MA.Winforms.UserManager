using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estanoco.MA.Winforms.UserManager
{
    public partial class ListUsersForm : Form
    {
        UserRepository repository = new UserRepository();
        public ListUsersForm()
        {
            InitializeComponent();
            LoadUsersToDataGridView();
        }

        private void LoadUsersToDataGridView()
        {
            List<User> users = repository.GetAll();
            dgViewUsers.DataSource = users;
        }

        private void dgViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(
                "Welcome to User Manager",
                "Greetings",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsersToDataGridView();
        }
    }
}
