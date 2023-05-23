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
        //Création des controller
        ProductController pdc = new ProductController();
        OrderController orderController = new OrderController();
        Viewlib vlib = new Viewlib();
        public OrdersForm()
        {
            InitializeComponent();
            //Set up des combobox et de la DGV
            orderDgv.DataSource = orderController.TableAllOrders();
            productCb.DataSource = pdc.SelectAllProductNames();
            triProductCb.DataSource = pdc.SelectAllProductNames();

            //Design de la datagridview
            orderDgv.Columns["id"].Visible = false;
            orderDgv.Columns["order_date"].HeaderText = "Date de la Commande";
            orderDgv.Columns["quantity"].HeaderText = "Quantité";
            orderDgv.Columns["unit_price"].HeaderText = "Prix Unitaire";
            orderDgv.Columns["product_name"].HeaderText = "Nom du produit";
        }

        //Gestion du clic sur le bouton Ajouter
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Récupération du nom du produit
            string productName = productCb.SelectedItem.ToString();

            //Création du produit grace à son nom
            Product product = pdc.SelectProductsByName(productName);

            //Création de la commande avec les données du formulaire
            Order order = new Order(orderDateDb.Value, product, (int)qteNb.Value, product.price);

            //Ajout de la commande en base de données
            orderController.AddOrder(order);

            //Mise à jour du stock du produit
            product.updateStock(order);

            //Mise à jour de la DGV
            vlib.RefreshDataGridOrder(orderDgv);
        }

        //Gestion du click sur le bouton Modifier
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Récupération du nom du produit
            string productName = productCb.SelectedItem.ToString();

            //Récupération du produit par son nom
            Product product = pdc.SelectProductsByName(productName);

            //Création de la commande avec les données du formulaire
            Order order = new Order((int)orderDgv.SelectedRows[0].Cells["id"].Value, orderDateDb.Value, product, ((int)qteNb.Value), product.price);
            
            //Mise à jour de la commande
            orderController.UpdateCommande(order);

            //Mise à jour de la DGV
            vlib.RefreshDataGridOrder(orderDgv);
        }

        //Destion du click sur le bouton supprimer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Récupération du produit grâce à son nom dans la colonne sélectionnée
            Product product = pdc.SelectProductsByName((string)orderDgv.SelectedRows[0].Cells["product_name"].Value);

            //Création de la commande avec les données du formulaire
            Order order = new Order(orderDateDb.Value, product, (int)qteNb.Value, product.price);

            //Mise à jour du stock du produit
            product.addStock(order);

            //Suppression de la commande
            orderController.DeleteCommande((int)orderDgv.SelectedRows[0].Cells["id"].Value);

            //Maj de la DGV
            vlib.RefreshDataGridOrder(orderDgv);
        }

        //Gestion de la sélection de ligne sur la DGV
        private void orderDgv_SelectionChanged(object sender, EventArgs e)
        {
            //Vérification qu'une ligne est selectionnée
            if (orderDgv.SelectedRows.Count > 0)
            {
                //Création d'une ligne
                DataGridViewRow row = orderDgv.SelectedRows[0];

                //Ajout des champs de la ligne dans le formulaire
                productCb.Text = row.Cells["product_name"].Value.ToString();
                qteNb.Value = (int)row.Cells["quantity"].Value;
                orderDateDb.Value = (DateTime)row.Cells["order_date"].Value;
            }
        }

        //Gestion du menu

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
