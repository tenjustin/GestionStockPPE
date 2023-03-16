using GestionStock.DAL;
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
        DBInit Con;
        DBCategories dbc;
        public CategoryForm()
        {
            InitializeComponent();
            Con = new DBInit();
            dbc = new DBCategories();
            categoriesList.DataSource = dbc.SelectAllCategories();
        }
    }
}
