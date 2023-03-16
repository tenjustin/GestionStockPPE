using GestionStock.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.lib
{
    internal class Viewlib
    {
        public void RefreshDataGridViewCategory(DataGridView dataGridView)
        {
            DBCategories categoryManager = new DBCategories();
            DataTable categoriesTable = categoryManager.TableAllCategories();
            dataGridView.DataSource = categoriesTable;
        }
    }
}
