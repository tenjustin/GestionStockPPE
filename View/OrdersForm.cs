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
    public partial class OrdersForm : Form
    {
        ProductController pdc = new ProductController();
        OrderController orderController = new OrderController();
        Viewlib vlib = new Viewlib();
        public OrdersForm()
        {
            InitializeComponent();
            orderDgv.DataSource = orderController.TableAllOrders();
            productCb.DataSource = pdc.SelectAllProductNames();
            triProductCb.DataSource = pdc.SelectAllProductNames();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = productCb.SelectedItem.ToString();
            Product product = pdc.SelectProductsByName(productName);
            Order order = new Order(orderDateDb.Value, product, (int)qteNb.Value, product.price);
            orderController.AddOrder(order);
            vlib.RefreshDataGridOrder(orderDgv);
        }

        private void unPriceTb_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // Autorise un seul point ou une seule virgule pour la décimale
            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string productName = productCb.SelectedItem.ToString();
            Product product = pdc.SelectProductsByName(productName);
            Order order = new Order((int)orderDgv.SelectedRows[0].Cells["id"].Value,orderDateDb.Value, product, ((int)qteNb.Value), product.price);
            orderController.UpdateCommande(order);
            vlib.RefreshDataGridOrder(orderDgv);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            orderController.DeleteCommande((int)orderDgv.SelectedRows[0].Cells["id"].Value);
            vlib.RefreshDataGridOrder(orderDgv);
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

        private void orderDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (orderDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = orderDgv.SelectedRows[0];
                productCb.Text = row.Cells["product_name"].Value.ToString();
                qteNb.Value = (int)row.Cells["quantity"].Value;
                orderDateDb.Value = (DateTime)row.Cells["order_date"].Value;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Connexion nextForm = new Connexion();

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
