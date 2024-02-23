namespace SalesWinApp
{
    partial class frmMembers
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
            dgvMembers = new DataGridView();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtCompanyName = new TextBox();
            txtEmail = new TextBox();
            numMemberId = new NumericUpDown();
            lbPassword = new Label();
            lbCountry = new Label();
            lbCity = new Label();
            lbCompanyName = new Label();
            lbEmail = new Label();
            lbMemberId = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            tcMembers = new TabControl();
            tpMain = new TabPage();
            tpFilter = new TabPage();
            btnResetFilter = new Button();
            btnSearch = new Button();
            label2 = new Label();
            cbCompanyName = new ComboBox();
            txtKeyword = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMemberId).BeginInit();
            tcMembers.SuspendLayout();
            tpMain.SuspendLayout();
            tpFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(14, 239);
            dgvMembers.Margin = new Padding(3, 2, 3, 2);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.RowTemplate.Height = 29;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(934, 205);
            dgvMembers.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(426, 92);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(426, 52);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(173, 23);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(426, 14);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(173, 23);
            txtCountry.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(150, 92);
            txtCompanyName.Margin = new Padding(3, 2, 3, 2);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.ReadOnly = true;
            txtCompanyName.Size = new Size(179, 23);
            txtCompanyName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 52);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 7;
            // 
            // numMemberId
            // 
            numMemberId.Location = new Point(150, 14);
            numMemberId.Margin = new Padding(3, 2, 3, 2);
            numMemberId.Name = "numMemberId";
            numMemberId.ReadOnly = true;
            numMemberId.Size = new Size(104, 23);
            numMemberId.TabIndex = 6;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(347, 98);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(347, 14);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(347, 57);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 3;
            lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(19, 98);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(94, 15);
            lbCompanyName.TabIndex = 2;
            lbCompanyName.Text = "Company Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(19, 57);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(19, 14);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(65, 15);
            lbMemberId.TabIndex = 0;
            lbMemberId.Text = "Member Id";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(347, 140);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(516, 140);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 140);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(19, 140);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 22);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // tcMembers
            // 
            tcMembers.Controls.Add(tpMain);
            tcMembers.Controls.Add(tpFilter);
            tcMembers.Location = new Point(10, 19);
            tcMembers.Margin = new Padding(3, 2, 3, 2);
            tcMembers.Name = "tcMembers";
            tcMembers.SelectedIndex = 0;
            tcMembers.Size = new Size(941, 205);
            tcMembers.TabIndex = 17;
            // 
            // tpMain
            // 
            tpMain.Controls.Add(lbEmail);
            tpMain.Controls.Add(lbCountry);
            tpMain.Controls.Add(btnDelete);
            tpMain.Controls.Add(btnUpdate);
            tpMain.Controls.Add(btnCreate);
            tpMain.Controls.Add(btnRefresh);
            tpMain.Controls.Add(lbCity);
            tpMain.Controls.Add(lbPassword);
            tpMain.Controls.Add(txtPassword);
            tpMain.Controls.Add(lbCompanyName);
            tpMain.Controls.Add(txtCity);
            tpMain.Controls.Add(numMemberId);
            tpMain.Controls.Add(txtCountry);
            tpMain.Controls.Add(lbMemberId);
            tpMain.Controls.Add(txtEmail);
            tpMain.Controls.Add(txtCompanyName);
            tpMain.Location = new Point(4, 24);
            tpMain.Margin = new Padding(3, 2, 3, 2);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3, 2, 3, 2);
            tpMain.Size = new Size(933, 177);
            tpMain.TabIndex = 0;
            tpMain.Text = "Main";
            tpMain.UseVisualStyleBackColor = true;
            // 
            // tpFilter
            // 
            tpFilter.Controls.Add(btnResetFilter);
            tpFilter.Controls.Add(btnSearch);
            tpFilter.Controls.Add(label2);
            tpFilter.Controls.Add(cbCompanyName);
            tpFilter.Controls.Add(txtKeyword);
            tpFilter.Controls.Add(label1);
            tpFilter.Location = new Point(4, 24);
            tpFilter.Margin = new Padding(3, 2, 3, 2);
            tpFilter.Name = "tpFilter";
            tpFilter.Padding = new Padding(3, 2, 3, 2);
            tpFilter.Size = new Size(933, 177);
            tpFilter.TabIndex = 1;
            tpFilter.Text = "Filter";
            tpFilter.UseVisualStyleBackColor = true;
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(29, 140);
            btnResetFilter.Margin = new Padding(3, 2, 3, 2);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(82, 22);
            btnResetFilter.TabIndex = 5;
            btnResetFilter.Text = "Reset Filter";
            btnResetFilter.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(145, 140);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(156, 22);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 104);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Company Name";
            // 
            // cbCompanyName
            // 
            cbCompanyName.FormattingEnabled = true;
            cbCompanyName.Location = new Point(145, 102);
            cbCompanyName.Margin = new Padding(3, 2, 3, 2);
            cbCompanyName.Name = "cbCompanyName";
            cbCompanyName.Size = new Size(156, 23);
            cbCompanyName.TabIndex = 2;
            cbCompanyName.Text = "Select Company Name";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(29, 58);
            txtKeyword.Margin = new Padding(3, 2, 3, 2);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Enter member email";
            txtKeyword.Size = new Size(273, 23);
            txtKeyword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 0;
            label1.Text = "Search Members";
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 455);
            Controls.Add(dgvMembers);
            Controls.Add(tcMembers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMembers";
            Text = "Members Management";
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMemberId).EndInit();
            tcMembers.ResumeLayout(false);
            tpMain.ResumeLayout(false);
            tpMain.PerformLayout();
            tpFilter.ResumeLayout(false);
            tpFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMembers;
        private Label lbEmail;
        private Label lbMemberId;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private NumericUpDown numMemberId;
        private Label lbPassword;
        private Label lbCountry;
        private Label lbCity;
        private Label lbCompanyName;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRefresh;
        private TabControl tcMembers;
        private TabPage tpMain;
        private TabPage tpFilter;
        private Label label1;
        private TextBox txtKeyword;
        private Label label2;
        private ComboBox cbCompanyName;
        private Button btnSearch;
        private Button btnResetFilter;
    }
}