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
            button10 = new Button();
            triProductCb = new ComboBox();
            btnUserForm = new Button();
            btnOrderForm = new Button();
            btnSupplierForm = new Button();
            btnCategForm = new Button();
            btnProductForm = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            orderDgv = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            orderDateDb = new DateTimePicker();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            productCb = new ComboBox();
            qteNb = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)orderDgv).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qteNb).BeginInit();
            SuspendLayout();
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
            // triProductCb
            // 
            triProductCb.FormattingEnabled = true;
            triProductCb.Location = new Point(740, 249);
            triProductCb.Name = "triProductCb";
            triProductCb.Size = new Size(121, 27);
            triProductCb.TabIndex = 38;
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
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 128, 255);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(994, 250);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(78, 28);
            btnRefresh.TabIndex = 40;
            btnRefresh.Text = "Trier";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 128, 255);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(801, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 28);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(128, 128, 255);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(458, 160);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 28);
            btnEdit.TabIndex = 36;
            btnEdit.Text = "Modifier";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 128, 255);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(630, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 28);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(643, 62);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 28;
            label4.Text = "Quantité";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 63);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 26;
            label3.Text = "Produit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 246);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 24;
            label2.Text = "Commandes";
            // 
            // orderDgv
            // 
            orderDgv.AllowUserToAddRows = false;
            orderDgv.AllowUserToDeleteRows = false;
            orderDgv.AllowUserToResizeColumns = false;
            orderDgv.AllowUserToResizeRows = false;
            orderDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDgv.Location = new Point(261, 282);
            orderDgv.MultiSelect = false;
            orderDgv.Name = "orderDgv";
            orderDgv.ReadOnly = true;
            orderDgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            orderDgv.RowTemplate.Height = 25;
            orderDgv.Size = new Size(811, 323);
            orderDgv.TabIndex = 23;
            orderDgv.SelectionChanged += orderDgv_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Lt", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(326, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 23);
            label1.TabIndex = 3;
            label1.Text = "Gestion des commandes";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(233, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 40);
            panel2.TabIndex = 22;
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
            panel1.TabIndex = 21;
            // 
            // orderDateDb
            // 
            orderDateDb.Format = DateTimePickerFormat.Short;
            orderDateDb.Location = new Point(823, 85);
            orderDateDb.Name = "orderDateDb";
            orderDateDb.Size = new Size(135, 27);
            orderDateDb.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(823, 63);
            label6.Name = "label6";
            label6.Size = new Size(164, 19);
            label6.TabIndex = 44;
            label6.Text = "Date de la commande";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(867, 249);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(121, 27);
            dateTimePicker2.TabIndex = 45;
            // 
            // productCb
            // 
            productCb.FormattingEnabled = true;
            productCb.Location = new Point(396, 85);
            productCb.Name = "productCb";
            productCb.Size = new Size(159, 27);
            productCb.TabIndex = 46;
            // 
            // qteNb
            // 
            qteNb.Location = new Point(643, 85);
            qteNb.Name = "qteNb";
            qteNb.Size = new Size(97, 27);
            qteNb.TabIndex = 47;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 617);
            Controls.Add(qteNb);
            Controls.Add(productCb);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(orderDateDb);
            Controls.Add(triProductCb);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(orderDgv);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)orderDgv).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)qteNb).EndInit();
            ResumeLayout(false);
            PerformLayout();
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