namespace GestionStock
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button10 = new Button();
            btnUserForm = new Button();
            btnOrderForm = new Button();
            btnSupplierForm = new Button();
            btnCategForm = new Button();
            btnProductForm = new Button();
            panel2 = new Panel();
            label1 = new Label();
            productDgv = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            nameTb = new TextBox();
            label4 = new Label();
            priceTb = new TextBox();
            categoryCb = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            supplierCb = new ComboBox();
            label7 = new Label();
            stockCb = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(btnUserForm);
            panel1.Controls.Add(btnOrderForm);
            panel1.Controls.Add(btnSupplierForm);
            panel1.Controls.Add(btnCategForm);
            panel1.Controls.Add(btnProductForm);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 617);
            panel1.TabIndex = 1;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(128, 128, 255);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(50, 562);
            button10.Name = "button10";
            button10.Size = new Size(125, 28);
            button10.TabIndex = 18;
            button10.Text = "Deconnexion";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // btnUserForm
            // 
            btnUserForm.FlatAppearance.BorderSize = 0;
            btnUserForm.FlatStyle = FlatStyle.Flat;
            btnUserForm.Location = new Point(50, 381);
            btnUserForm.Name = "btnUserForm";
            btnUserForm.Size = new Size(122, 35);
            btnUserForm.TabIndex = 4;
            btnUserForm.Text = "Utilisateurs";
            btnUserForm.TextAlign = ContentAlignment.MiddleLeft;
            btnUserForm.UseVisualStyleBackColor = true;
            btnUserForm.Click += btnUserForm_Click;
            // 
            // btnOrderForm
            // 
            btnOrderForm.FlatAppearance.BorderSize = 0;
            btnOrderForm.FlatStyle = FlatStyle.Flat;
            btnOrderForm.Location = new Point(50, 329);
            btnOrderForm.Name = "btnOrderForm";
            btnOrderForm.Size = new Size(122, 35);
            btnOrderForm.TabIndex = 3;
            btnOrderForm.Text = "Commandes";
            btnOrderForm.TextAlign = ContentAlignment.MiddleLeft;
            btnOrderForm.UseVisualStyleBackColor = true;
            btnOrderForm.Click += btnOrderForm_Click;
            // 
            // btnSupplierForm
            // 
            btnSupplierForm.FlatAppearance.BorderSize = 0;
            btnSupplierForm.FlatStyle = FlatStyle.Flat;
            btnSupplierForm.Location = new Point(50, 282);
            btnSupplierForm.Name = "btnSupplierForm";
            btnSupplierForm.Size = new Size(122, 35);
            btnSupplierForm.TabIndex = 2;
            btnSupplierForm.Text = "Fournisseurs";
            btnSupplierForm.TextAlign = ContentAlignment.MiddleLeft;
            btnSupplierForm.UseVisualStyleBackColor = true;
            btnSupplierForm.Click += btnSupplierForm_Click;
            // 
            // btnCategForm
            // 
            btnCategForm.FlatAppearance.BorderSize = 0;
            btnCategForm.FlatStyle = FlatStyle.Flat;
            btnCategForm.Location = new Point(50, 237);
            btnCategForm.Name = "btnCategForm";
            btnCategForm.Size = new Size(104, 36);
            btnCategForm.TabIndex = 1;
            btnCategForm.Text = "Catégories";
            btnCategForm.TextAlign = ContentAlignment.MiddleLeft;
            btnCategForm.UseVisualStyleBackColor = true;
            btnCategForm.Click += btnCategForm_Click;
            // 
            // btnProductForm
            // 
            btnProductForm.FlatAppearance.BorderSize = 0;
            btnProductForm.FlatStyle = FlatStyle.Flat;
            btnProductForm.Location = new Point(50, 199);
            btnProductForm.Name = "btnProductForm";
            btnProductForm.Size = new Size(104, 23);
            btnProductForm.TabIndex = 0;
            btnProductForm.Text = "Produits";
            btnProductForm.TextAlign = ContentAlignment.MiddleLeft;
            btnProductForm.UseVisualStyleBackColor = true;
            btnProductForm.Click += btnProductForm_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(233, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 40);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Lt", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(336, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 23);
            label1.TabIndex = 3;
            label1.Text = "Gestion des produits";
            // 
            // productDgv
            // 
            productDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDgv.Location = new Point(261, 282);
            productDgv.Name = "productDgv";
            productDgv.ReadOnly = true;
            productDgv.RowTemplate.Height = 25;
            productDgv.Size = new Size(811, 323);
            productDgv.TabIndex = 3;
            productDgv.SelectionChanged += productDgv_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 246);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 4;
            label2.Text = "Inventaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 66);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 6;
            label3.Text = "Nom";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(277, 88);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(163, 27);
            nameTb.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 66);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 8;
            label4.Text = "Prix (€)";
            // 
            // priceTb
            // 
            priceTb.Location = new Point(446, 88);
            priceTb.Name = "priceTb";
            priceTb.Size = new Size(163, 27);
            priceTb.TabIndex = 7;
            priceTb.KeyPress += priceTb_KeyPress;
            // 
            // categoryCb
            // 
            categoryCb.FormattingEnabled = true;
            categoryCb.Location = new Point(615, 88);
            categoryCb.Name = "categoryCb";
            categoryCb.Size = new Size(152, 27);
            categoryCb.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 66);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 10;
            label5.Text = "Catégorie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(771, 66);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 12;
            label6.Text = "Fournisseur";
            // 
            // supplierCb
            // 
            supplierCb.FormattingEnabled = true;
            supplierCb.Location = new Point(771, 88);
            supplierCb.Name = "supplierCb";
            supplierCb.Size = new Size(168, 27);
            supplierCb.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(945, 66);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 14;
            label7.Text = "Stock";
            // 
            // stockCb
            // 
            stockCb.Location = new Point(945, 88);
            stockCb.Name = "stockCb";
            stockCb.Size = new Size(85, 27);
            stockCb.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 128, 255);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(630, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 28);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(128, 128, 255);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(458, 160);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 28);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Modifier";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 128, 255);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(801, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 28);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 617);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(stockCb);
            Controls.Add(label6);
            Controls.Add(supplierCb);
            Controls.Add(label5);
            Controls.Add(categoryCb);
            Controls.Add(label4);
            Controls.Add(priceTb);
            Controls.Add(label3);
            Controls.Add(nameTb);
            Controls.Add(label2);
            Controls.Add(productDgv);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView productDgv;
        private Label label2;
        private Label label3;
        private TextBox nameTb;
        private Label label4;
        private TextBox priceTb;
        private ComboBox categoryCb;
        private Label label5;
        private Label label6;
        private ComboBox supplierCb;
        private Label label7;
        private TextBox stockCb;
        private Button button10;
        private Button btnUserForm;
        private Button btnOrderForm;
        private Button btnSupplierForm;
        private Button btnCategForm;
        private Button btnProductForm;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}