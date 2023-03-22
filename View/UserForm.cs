using GestionStock.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class UserForm : Form
    {
        RoleController roleController = new RoleController();
        UserController userController = new UserController();
        public UserForm()
        {
            InitializeComponent();
            roleCb.DataSource = roleController.GetAllRoleNames();
            usersDgv.DataSource = userController.TableAllUsers();
        }

        private void usersDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (usersDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = usersDgv.SelectedRows[0];
                usernameTb.Text = (string)row.Cells["username"].Value;
                passwordTB.Text = (string)row.Cells["password"].Value;
            }
        }
    }
}
