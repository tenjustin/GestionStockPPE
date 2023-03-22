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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.btnSupplierForm = new System.Windows.Forms.Button();
            this.btnCategForm = new System.Windows.Forms.Button();
            this.btnProductForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productDgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.supplierCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stockCb = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.triCatCb = new System.Windows.Forms.ComboBox();
            this.triSupCb = new System.Windows.Forms.ComboBox();
            this.btnTri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.btnUserForm);
            this.panel1.Controls.Add(this.btnOrderForm);
            this.panel1.Controls.Add(this.btnSupplierForm);
            this.panel1.Controls.Add(this.btnCategForm);
            this.panel1.Controls.Add(this.btnProductForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 617);
            this.panel1.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(50, 562);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(125, 28);
            this.button10.TabIndex = 18;
            this.button10.Text = "Deconnexion";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btnUserForm
            // 
            this.btnUserForm.FlatAppearance.BorderSize = 0;
            this.btnUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserForm.Location = new System.Drawing.Point(50, 381);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(122, 35);
            this.btnUserForm.TabIndex = 4;
            this.btnUserForm.Text = "Utilisateurs";
            this.btnUserForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.FlatAppearance.BorderSize = 0;
            this.btnOrderForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderForm.Location = new System.Drawing.Point(50, 329);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.Size = new System.Drawing.Size(122, 35);
            this.btnOrderForm.TabIndex = 3;
            this.btnOrderForm.Text = "Commandes";
            this.btnOrderForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderForm.UseVisualStyleBackColor = true;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // btnSupplierForm
            // 
            this.btnSupplierForm.FlatAppearance.BorderSize = 0;
            this.btnSupplierForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierForm.Location = new System.Drawing.Point(50, 282);
            this.btnSupplierForm.Name = "btnSupplierForm";
            this.btnSupplierForm.Size = new System.Drawing.Size(122, 35);
            this.btnSupplierForm.TabIndex = 2;
            this.btnSupplierForm.Text = "Fournisseurs";
            this.btnSupplierForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierForm.UseVisualStyleBackColor = true;
            this.btnSupplierForm.Click += new System.EventHandler(this.btnSupplierForm_Click);
            // 
            // btnCategForm
            // 
            this.btnCategForm.FlatAppearance.BorderSize = 0;
            this.btnCategForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategForm.Location = new System.Drawing.Point(50, 237);
            this.btnCategForm.Name = "btnCategForm";
            this.btnCategForm.Size = new System.Drawing.Size(104, 36);
            this.btnCategForm.TabIndex = 1;
            this.btnCategForm.Text = "Catégories";
            this.btnCategForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategForm.UseVisualStyleBackColor = true;
            this.btnCategForm.Click += new System.EventHandler(this.btnCategForm_Click);
            // 
            // btnProductForm
            // 
            this.btnProductForm.FlatAppearance.BorderSize = 0;
            this.btnProductForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductForm.Location = new System.Drawing.Point(50, 199);
            this.btnProductForm.Name = "btnProductForm";
            this.btnProductForm.Size = new System.Drawing.Size(104, 23);
            this.btnProductForm.TabIndex = 0;
            this.btnProductForm.Text = "Produits";
            this.btnProductForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductForm.UseVisualStyleBackColor = true;
            this.btnProductForm.Click += new System.EventHandler(this.btnProductForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 40);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des produits";
            // 
            // productDgv
            // 
            this.productDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDgv.Location = new System.Drawing.Point(261, 282);
            this.productDgv.Name = "productDgv";
            this.productDgv.RowTemplate.Height = 25;
            this.productDgv.Size = new System.Drawing.Size(811, 323);
            this.productDgv.TabIndex = 3;
            this.productDgv.SelectionChanged += new System.EventHandler(this.productDgv_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inventaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(277, 88);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(163, 27);
            this.nameTb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prix (€)";
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(446, 88);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(163, 27);
            this.priceTb.TabIndex = 7;
            this.priceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTb_KeyPress);
            // 
            // categoryCb
            // 
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Location = new System.Drawing.Point(615, 88);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(152, 27);
            this.categoryCb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Catégorie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fournisseur";
            // 
            // supplierCb
            // 
            this.supplierCb.FormattingEnabled = true;
            this.supplierCb.Location = new System.Drawing.Point(771, 88);
            this.supplierCb.Name = "supplierCb";
            this.supplierCb.Size = new System.Drawing.Size(168, 27);
            this.supplierCb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(945, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock";
            // 
            // stockCb
            // 
            this.stockCb.Location = new System.Drawing.Point(945, 88);
            this.stockCb.Name = "stockCb";
            this.stockCb.Size = new System.Drawing.Size(85, 27);
            this.stockCb.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(630, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 28);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(458, 160);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 28);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(801, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 28);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // triCatCb
            // 
            this.triCatCb.FormattingEnabled = true;
            this.triCatCb.Location = new System.Drawing.Point(740, 249);
            this.triCatCb.Name = "triCatCb";
            this.triCatCb.Size = new System.Drawing.Size(121, 27);
            this.triCatCb.TabIndex = 18;
            // 
            // triSupCb
            // 
            this.triSupCb.FormattingEnabled = true;
            this.triSupCb.Location = new System.Drawing.Point(867, 249);
            this.triSupCb.Name = "triSupCb";
            this.triSupCb.Size = new System.Drawing.Size(121, 27);
            this.triSupCb.TabIndex = 19;
            // 
            // btnTri
            // 
            this.btnTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTri.FlatAppearance.BorderSize = 0;
            this.btnTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTri.Location = new System.Drawing.Point(994, 250);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(78, 28);
            this.btnTri.TabIndex = 20;
            this.btnTri.Text = "Trier";
            this.btnTri.UseVisualStyleBackColor = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 617);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.triSupCb);
            this.Controls.Add(this.triCatCb);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stockCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.supplierCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productDgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox triCatCb;
        private ComboBox triSupCb;
        private Button btnTri;
    }
}