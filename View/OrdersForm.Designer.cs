namespace GestionStock
{
    partial class OrdersForm
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
            this.button10 = new System.Windows.Forms.Button();
            this.triProductCb = new System.Windows.Forms.ComboBox();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.btnSupplierForm = new System.Windows.Forms.Button();
            this.btnCategForm = new System.Windows.Forms.Button();
            this.btnProductForm = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderDateDb = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.productCb = new System.Windows.Forms.ComboBox();
            this.qteNb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qteNb)).BeginInit();
            this.SuspendLayout();
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
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // triProductCb
            // 
            this.triProductCb.FormattingEnabled = true;
            this.triProductCb.Location = new System.Drawing.Point(740, 249);
            this.triProductCb.Name = "triProductCb";
            this.triProductCb.Size = new System.Drawing.Size(121, 27);
            this.triProductCb.TabIndex = 38;
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
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(994, 250);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 28);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Trier";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(801, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 28);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(458, 160);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 28);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(630, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 28);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Commandes";
            // 
            // orderDgv
            // 
            this.orderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDgv.Location = new System.Drawing.Point(261, 282);
            this.orderDgv.Name = "orderDgv";
            this.orderDgv.RowTemplate.Height = 25;
            this.orderDgv.Size = new System.Drawing.Size(811, 323);
            this.orderDgv.TabIndex = 23;
            this.orderDgv.SelectionChanged += new System.EventHandler(this.orderDgv_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des commandes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 40);
            this.panel2.TabIndex = 22;
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
            this.panel1.TabIndex = 21;
            // 
            // orderDateDb
            // 
            this.orderDateDb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDateDb.Location = new System.Drawing.Point(823, 85);
            this.orderDateDb.Name = "orderDateDb";
            this.orderDateDb.Size = new System.Drawing.Size(135, 27);
            this.orderDateDb.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(823, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Date de la commande";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(867, 249);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 27);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // productCb
            // 
            this.productCb.FormattingEnabled = true;
            this.productCb.Location = new System.Drawing.Point(396, 85);
            this.productCb.Name = "productCb";
            this.productCb.Size = new System.Drawing.Size(159, 27);
            this.productCb.TabIndex = 46;
            // 
            // qteNb
            // 
            this.qteNb.Location = new System.Drawing.Point(643, 85);
            this.qteNb.Name = "qteNb";
            this.qteNb.Size = new System.Drawing.Size(97, 27);
            this.qteNb.TabIndex = 47;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 617);
            this.Controls.Add(this.qteNb);
            this.Controls.Add(this.productCb);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderDateDb);
            this.Controls.Add(this.triProductCb);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderDgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qteNb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button10;
        private ComboBox triProductCb;
        private Button btnUserForm;
        private Button btnOrderForm;
        private Button btnSupplierForm;
        private Button btnCategForm;
        private Button btnProductForm;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView orderDgv;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private DateTimePicker orderDateDb;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private ComboBox productCb;
        private NumericUpDown qteNb;
    }
}