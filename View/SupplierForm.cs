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
    public partial class SupplierForm : Form
    {
        SuppliersController spc = new SuppliersController();
        Viewlib vlib = new Viewlib();
        public SupplierForm()
        {
            InitializeComponent();
            supplierDgv.DataSource = spc.TableAllSuppliers();
        }

        private void supplierDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (supplierDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = supplierDgv.SelectedRows[0];
                nameTb.Text = row.Cells["name"].Value.ToString();
                addressTb.Text = row.Cells["address"].Value.ToString();
                phoneTb.Text = row.Cells["phone_number"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nameTb.Text != null && addressTb.Text != null && phoneTb != null)
            {
                Supplier supplier = new Supplier(nameTb.Text, addressTb.Text, phoneTb.Text);
                spc.AddSupplier(supplier);
                vlib.RefreshDataGridSupplier(supplierDgv);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (nameTb.Text != null && addressTb.Text != null && phoneTb != null)
            {
                DataGridViewRow row = supplierDgv.SelectedRows[0];
                Supplier supplier = new Supplier((int)row.Cells["id"].Value, nameTb.Text, addressTb.Text, phoneTb.Text);
                spc.UpdateSupplier(supplier);
                vlib.RefreshDataGridSupplier(supplierDgv);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (supplierDgv.SelectedRows.Count > 0)
            {
                spc.DeleteSupplier((int)supplierDgv.SelectedRows[0].Cells["id"].Value);
                vlib.RefreshDataGridSupplier(supplierDgv);
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
    }
}
