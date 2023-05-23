namespace GestionStock
{
    partial class SupplierForm
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
            label5 = new Label();
            phoneTb = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label4 = new Label();
            addressTb = new TextBox();
            label3 = new Label();
            nameTb = new TextBox();
            label2 = new Label();
            supplierDgv = new DataGridView();
            btnCategForm = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button10 = new Button();
            btnUserForm = new Button();
            btnOrderForm = new Button();
            btnSupplierForm = new Button();
            btnProductForm = new Button();
            ((System.ComponentModel.ISupportInitialize)supplierDgv).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(801, 59);
            label5.Name = "label5";
            label5.Size = new Size(160, 19);
            label5.TabIndex = 60;
            label5.Text = "Numéro de téléphone";
            // 
            // phoneTb
            // 
            phoneTb.Location = new Point(801, 81);
            phoneTb.Name = "phoneTb";
            phoneTb.Size = new Size(160, 27);
            phoneTb.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Lt", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(326, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 23);
            label1.TabIndex = 3;
            label1.Text = "Gestion des fournisseurs";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 128, 255);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(801, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 28);
            btnDelete.TabIndex = 56;
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
            btnEdit.TabIndex = 55;
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
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 59);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 53;
            label4.Text = "Adresse";
            // 
            // addressTb
            // 
            addressTb.Location = new Point(547, 81);
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(248, 27);
            addressTb.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 59);
            label3.Name = "label3";
            label3.Size = new Size(128, 19);
            label3.TabIndex = 51;
            label3.Text = "Nom fournisseur";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(365, 81);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(176, 27);
            nameTb.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 246);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 49;
            label2.Text = "Fournisseurs";
            // 
            // supplierDgv
            // 
            supplierDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supplierDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            supplierDgv.Location = new Point(261, 282);
            supplierDgv.Name = "supplierDgv";
            supplierDgv.ReadOnly = true;
            supplierDgv.RowTemplate.Height = 25;
            supplierDgv.Size = new Size(811, 323);
            supplierDgv.TabIndex = 48;
            supplierDgv.SelectionChanged += supplierDgv_SelectionChanged;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(233, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 40);
            panel2.TabIndex = 47;
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
            panel1.TabIndex = 46;
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
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 617);
            Controls.Add(label5);
            Controls.Add(phoneTb);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(addressTb);
            Controls.Add(label3);
            Controls.Add(nameTb);
            Controls.Add(label2);
            Controls.Add(supplierDgv);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)supplierDgv).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox phoneTb;
        private Label label1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label4;
        private TextBox addressTb;
        private Label label3;
        private TextBox nameTb;
        private Label label2;
        private DataGridView supplierDgv;
        private Button btnCategForm;
        private Panel panel2;
        private Panel panel1;
        private Button button10;
        private Button btnUserForm;
        private Button btnOrderForm;
        private Button btnSupplierForm;
        private Button btnProductForm;
    }
}