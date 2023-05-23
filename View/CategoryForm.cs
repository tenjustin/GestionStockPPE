using GestionStock.DAL;
using GestionStock.lib;
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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            CategoryController dbc = new CategoryController();
            categoriesList.DataSource = dbc.TableAllCategories();

            categoriesList.Columns["id"].Visible = false;
            categoriesList.Columns["name"].HeaderText = "Nom";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryController dbc = new CategoryController();
            Viewlib vlib = new Viewlib();
            dbc.AddCategorie(categoryNameTB.Text);
            vlib.RefreshDataGridViewCategory(categoriesList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Viewlib vlib = new Viewlib();
            if (categoriesList.SelectedRows.Count > 0)
            {
                int categoryId = (int)categoriesList.SelectedRows[0].Cells["id"].Value;

                CategoryController categoryManager = new CategoryController();
                bool success = categoryManager.DeleteCategoryById(categoryId);

                if (success)
                {
                    // La catégorie a été supprimée avec succès
                    MessageBox.Show("La catégorie a été supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualisez la DataGridView pour afficher les données à jour
                    vlib.RefreshDataGridViewCategory(categoriesList);
                }
                else
                {
                    // Une erreur s'est produite lors de la suppression de la catégorie
                    MessageBox.Show("Une erreur s'est produite lors de la suppression de la catégorie.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Viewlib vlib = new Viewlib();
            if (categoriesList.SelectedRows.Count > 0)
            {
                int categoryId = (int)categoriesList.SelectedRows[0].Cells["id"].Value;
                string newCategoryName = categoryNameTB.Text;

                if (!string.IsNullOrEmpty(newCategoryName))
                {
                    CategoryController categoryManager = new CategoryController();
                    bool success = categoryManager.UpdateCategoryById(categoryId, newCategoryName);

                    if (success)
                    {
                        // La catégorie a été modifiée avec succès
                        MessageBox.Show("La catégorie a été modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualisez la DataGridView pour afficher les données à jour
                        vlib.RefreshDataGridViewCategory(categoriesList);
                    }
                    else
                    {
                        // Une erreur s'est produite lors de la modification de la catégorie
                        MessageBox.Show("Une erreur s'est produite lors de la modification de la catégorie.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez saisir un nouveau nom pour la catégorie.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void categoriesList_SelectionChanged(object sender, EventArgs e)
        {
            if (categoriesList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = categoriesList.SelectedRows[0];
                string catName = row.Cells["name"].Value.ToString();
                categoryNameTB.Text = catName;
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
