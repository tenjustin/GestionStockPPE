using GestionStock.Controller;
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
            CategoryController categoryManager = new CategoryController();
            DataTable categoriesTable = categoryManager.TableAllCategories();
            dataGridView.DataSource = categoriesTable;
        }

        public void RefreshDataGridOrder(DataGridView dataGridView) 
        { 
            OrderController orderController = new OrderController();  
            DataTable orderTable = orderController.TableAllOrders();
            dataGridView.DataSource = orderTable;
        }

        public void RefreshDataGridSupplier(DataGridView dataGridView)
        {
            SuppliersController supplierController = new SuppliersController();
            DataTable supplierTable = supplierController.TableAllSuppliers();
            dataGridView.DataSource = supplierTable;
        }

        public void RefreshDataGridProduct(DataGridView dataGridView)
        {
            ProductController productController = new ProductController();
            DataTable productTable = productController.TableAllProducts();
            dataGridView.DataSource = productTable;
        }
    }
}
