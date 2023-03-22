using GestionStock.Controller;
using GestionStock.lib;
using GestionStock.Model;
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
        Viewlib vlib = new Viewlib();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Role role = roleController.GetRoleByName(roleCb.Text);
            User user = new User(usernameTb.Text, passwordTB.Text, role);
            userController.AddUser(user);
            vlib.RefreshDataGridUser(usersDgv);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            userController.DeleteUserById((int)usersDgv.SelectedRows[0].Cells["id"].Value);
            vlib.RefreshDataGridUser(usersDgv);
        }

        private void btnProductForm_Click(object sender, EventArgs e)
        {
            ProductForm nextForm = new ProductForm();

            // Crée un nouveau thread pour exécuter le nouveau formulaire
            Thread newFormThread = new Thread(() => Program.RunForm(nextForm));

            // Démarre le nouveau thread
            newFormThread.SetApartmentState(ApartmentState.STA);
            newFormThread.Start();

            // Ferme le formulaire actuel
            this.Close();
        }

        private void btnCategForm_Click(object sender, EventArgs e)
        {
            CategoryForm nextForm = new CategoryForm();

            // Crée un nouveau thread pour exécuter le nouveau formulaire
            Thread newFormThread = new Thread(() => Program.RunForm(nextForm));

            // Démarre le nouveau thread
            newFormThread.SetApartmentState(ApartmentState.STA);
            newFormThread.Start();

            // Ferme le formulaire actuel
            this.Close();
        }

        private void btnSupplierForm_Click(object sender, EventArgs e)
        {
            SupplierForm nextForm = new SupplierForm();

            // Crée un nouveau thread pour exécuter le nouveau formulaire
            Thread newFormThread = new Thread(() => Program.RunForm(nextForm));

            // Démarre le nouveau thread
            newFormThread.SetApartmentState(ApartmentState.STA);
            newFormThread.Start();

            // Ferme le formulaire actuel
            this.Close();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            OrdersForm nextForm = new OrdersForm();

            // Crée un nouveau thread pour exécuter le nouveau formulaire
            Thread newFormThread = new Thread(() => Program.RunForm(nextForm));

            // Démarre le nouveau thread
            newFormThread.SetApartmentState(ApartmentState.STA);
            newFormThread.Start();

            // Ferme le formulaire actuel
            this.Close();
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            UserForm nextForm = new UserForm();

            // Crée un nouveau thread pour exécuter le nouveau formulaire
            Thread newFormThread = new Thread(() => Program.RunForm(nextForm));

            // Démarre le nouveau thread
            newFormThread.SetApartmentState(ApartmentState.STA);
            newFormThread.Start();

            // Ferme le formulaire actuel
            this.Close();
        }
    }
}
