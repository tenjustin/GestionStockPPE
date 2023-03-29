using GestionStock.Controller;
using GestionStock.DAL;
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
    public partial class ProductForm : Form
    {
        ProductController pdc = new ProductController();
        CategoryController categoryController = new CategoryController();
        SuppliersController suppliersController = new SuppliersController();
        Viewlib vlib = new Viewlib();
        public ProductForm()
        {
            InitializeComponent();
            productDgv.DataSource = pdc.TableAllProducts();
            categoryCb.DataSource = categoryController.SelectAllCategoryNames();
            supplierCb.DataSource = suppliersController.SelectAllSuppliersNames();
            triCatCb.DataSource = categoryController.SelectAllCategoryNames();
            triSupCb.DataSource = suppliersController.SelectAllSuppliersNames();
        }

        private void productDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (productDgv.SelectedRows.Count > 0)
            {
                nameTb.Text = productDgv.SelectedRows[0].Cells["name"].Value.ToString();
                priceTb.Text = productDgv.SelectedRows[0].Cells["price"].Value.ToString();
                stockCb.Text = productDgv.SelectedRows[0].Cells["quantity"].Value.ToString();
                categoryCb.Text = productDgv.SelectedRows[0].Cells["category_name"].Value.ToString();
                supplierCb.Text = productDgv.SelectedRows[0].Cells["supplier_name"].Value.ToString();
            }
        }

        private void priceTb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = categoryController.GetCategoryByName(categoryCb.Text);
            Supplier supplier = suppliersController.GetSupplierByName(supplierCb.Text);
            double.TryParse(priceTb.Text, out double price);
            int.TryParse(stockCb.Text, out int quantity);
            Product product = new Product(nameTb.Text, price, quantity, category, supplier);
            pdc.AddProduct(product);
            vlib.RefreshDataGridProduct(productDgv);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Category category = categoryController.GetCategoryByName(categoryCb.Text);
            Supplier supplier = suppliersController.GetSupplierByName(supplierCb.Text);
            double.TryParse(priceTb.Text, out double price);
            int.TryParse(stockCb.Text, out int quantity);
            Product product = new Product(nameTb.Text, price, quantity, category, supplier);
            pdc.UpdateProduct(product);
            vlib.RefreshDataGridProduct(productDgv);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productDgv.SelectedRows.Count > 0)
            {
                pdc.DeleteProduct((int)productDgv.SelectedRows[0].Cells["id"].Value);
                vlib.RefreshDataGridProduct(productDgv);
            }
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
