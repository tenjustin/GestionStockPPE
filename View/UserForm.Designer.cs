namespace GestionStock
{
    partial class UserForm
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
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.btnSupplierForm = new System.Windows.Forms.Button();
            this.btnCategForm = new System.Windows.Forms.Button();
            this.btnProductForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Utilisateur = new System.Windows.Forms.Label();
            this.usersDgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.roleCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(801, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Rôle";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(801, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 28);
            this.btnDelete.TabIndex = 71;
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
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(630, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 28);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(614, 81);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(160, 27);
            this.passwordTB.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "Identifiant";
            // 
            // Utilisateur
            // 
            this.Utilisateur.AutoSize = true;
            this.Utilisateur.Location = new System.Drawing.Point(277, 246);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(90, 19);
            this.Utilisateur.TabIndex = 64;
            this.Utilisateur.Text = "Utilisateurs";
            // 
            // usersDgv
            // 
            this.usersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDgv.Location = new System.Drawing.Point(261, 282);
            this.usersDgv.Name = "usersDgv";
            this.usersDgv.RowTemplate.Height = 25;
            this.usersDgv.Size = new System.Drawing.Size(811, 323);
            this.usersDgv.TabIndex = 63;
            this.usersDgv.SelectionChanged += new System.EventHandler(this.usersDgv_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 40);
            this.panel2.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des utilisateurs";
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
            this.panel1.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "Mot de passe";
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(415, 81);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(176, 27);
            this.usernameTb.TabIndex = 65;
            // 
            // roleCb
            // 
            this.roleCb.FormattingEnabled = true;
            this.roleCb.Location = new System.Drawing.Point(801, 81);
            this.roleCb.Name = "roleCb";
            this.roleCb.Size = new System.Drawing.Size(151, 27);
            this.roleCb.TabIndex = 74;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 617);
            this.Controls.Add(this.roleCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Utilisateur);
            this.Controls.Add(this.usersDgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameTb);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button10;
        private Button btnUserForm;
        private Button btnOrderForm;
        private Button btnSupplierForm;
        private Button btnCategForm;
        private Button btnProductForm;
        private Label label5;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox passwordTB;
        private Label label3;
        private Label Utilisateur;
        private DataGridView usersDgv;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox usernameTb;
        private ComboBox roleCb;
    }
}