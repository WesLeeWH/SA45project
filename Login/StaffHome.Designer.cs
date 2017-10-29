namespace Login
{
    partial class StaffHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHome));
            this.DateLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ChangePasswordbtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewBookListBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ViewCusListBtn = new System.Windows.Forms.Button();
            this.ViewExtentionAppBtn = new System.Windows.Forms.Button();
            this.GetReportBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ViewIssueTranBtn = new System.Windows.Forms.Button();
            this.ViewPaymentTranBtn = new System.Windows.Forms.Button();
            this.ViewAuthorListBtn = new System.Windows.Forms.Button();
            this.ViewPublisherListbtn = new System.Windows.Forms.Button();
            this.ViewCountryListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(24, 40);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(49, 22);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "Date";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(70, 352);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(811, 254);
            this.dataGridView.TabIndex = 16;
            // 
            // ChangePasswordbtn
            // 
            this.ChangePasswordbtn.BackColor = System.Drawing.Color.Ivory;
            this.ChangePasswordbtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordbtn.Location = new System.Drawing.Point(689, 9);
            this.ChangePasswordbtn.Name = "ChangePasswordbtn";
            this.ChangePasswordbtn.Size = new System.Drawing.Size(115, 36);
            this.ChangePasswordbtn.TabIndex = 14;
            this.ChangePasswordbtn.Text = "ChangePassword";
            this.ChangePasswordbtn.UseVisualStyleBackColor = false;
            this.ChangePasswordbtn.Click += new System.EventHandler(this.ChangePasswordbtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Ivory;
            this.LogoutBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(827, 9);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(115, 36);
            this.LogoutBtn.TabIndex = 13;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.StaffNameLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameLabel.Location = new System.Drawing.Point(145, 7);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Size = new System.Drawing.Size(138, 31);
            this.StaffNameLabel.TabIndex = 12;
            this.StaffNameLabel.Text = "StaffName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome!";
            // 
            // ViewBookListBtn
            // 
            this.ViewBookListBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewBookListBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBookListBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewBookListBtn.Image")));
            this.ViewBookListBtn.Location = new System.Drawing.Point(138, 64);
            this.ViewBookListBtn.Name = "ViewBookListBtn";
            this.ViewBookListBtn.Size = new System.Drawing.Size(139, 117);
            this.ViewBookListBtn.TabIndex = 18;
            this.ViewBookListBtn.Text = "View Book List";
            this.ViewBookListBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewBookListBtn.UseVisualStyleBackColor = false;
            this.ViewBookListBtn.Click += new System.EventHandler(this.ViewBookListBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(587, 319);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(125, 27);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "SearchBooks";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(262, 320);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(280, 26);
            this.SearchBox.TabIndex = 19;
            // 
            // ViewCusListBtn
            // 
            this.ViewCusListBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewCusListBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCusListBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewCusListBtn.Image")));
            this.ViewCusListBtn.Location = new System.Drawing.Point(283, 64);
            this.ViewCusListBtn.Name = "ViewCusListBtn";
            this.ViewCusListBtn.Size = new System.Drawing.Size(139, 117);
            this.ViewCusListBtn.TabIndex = 21;
            this.ViewCusListBtn.Text = "View Customer List";
            this.ViewCusListBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewCusListBtn.UseVisualStyleBackColor = false;
            this.ViewCusListBtn.Click += new System.EventHandler(this.ViewCusListBtn_Click);
            // 
            // ViewExtentionAppBtn
            // 
            this.ViewExtentionAppBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewExtentionAppBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewExtentionAppBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewExtentionAppBtn.Image")));
            this.ViewExtentionAppBtn.Location = new System.Drawing.Point(428, 64);
            this.ViewExtentionAppBtn.Name = "ViewExtentionAppBtn";
            this.ViewExtentionAppBtn.Size = new System.Drawing.Size(139, 117);
            this.ViewExtentionAppBtn.TabIndex = 22;
            this.ViewExtentionAppBtn.Text = "View Extension Application";
            this.ViewExtentionAppBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewExtentionAppBtn.UseVisualStyleBackColor = false;
            this.ViewExtentionAppBtn.Click += new System.EventHandler(this.ViewExtentionAppBtn_Click);
            // 
            // GetReportBtn
            // 
            this.GetReportBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GetReportBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("GetReportBtn.Image")));
            this.GetReportBtn.Location = new System.Drawing.Point(573, 66);
            this.GetReportBtn.Name = "GetReportBtn";
            this.GetReportBtn.Size = new System.Drawing.Size(139, 117);
            this.GetReportBtn.TabIndex = 23;
            this.GetReportBtn.Text = "Get Report";
            this.GetReportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GetReportBtn.UseVisualStyleBackColor = false;
            this.GetReportBtn.Click += new System.EventHandler(this.GetReportBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(144, 612);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(139, 117);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.Image")));
            this.UpdateBtn.Location = new System.Drawing.Point(420, 612);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(139, 117);
            this.UpdateBtn.TabIndex = 25;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(665, 612);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(139, 117);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Delete";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ViewIssueTranBtn
            // 
            this.ViewIssueTranBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewIssueTranBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewIssueTranBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewIssueTranBtn.Image")));
            this.ViewIssueTranBtn.Location = new System.Drawing.Point(718, 66);
            this.ViewIssueTranBtn.Name = "ViewIssueTranBtn";
            this.ViewIssueTranBtn.Size = new System.Drawing.Size(139, 117);
            this.ViewIssueTranBtn.TabIndex = 27;
            this.ViewIssueTranBtn.Text = "View IssueTran";
            this.ViewIssueTranBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewIssueTranBtn.UseVisualStyleBackColor = false;
            this.ViewIssueTranBtn.Click += new System.EventHandler(this.ViewIssueTranBtn_Click);
            // 
            // ViewPaymentTranBtn
            // 
            this.ViewPaymentTranBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewPaymentTranBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPaymentTranBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewPaymentTranBtn.Image")));
            this.ViewPaymentTranBtn.Location = new System.Drawing.Point(138, 187);
            this.ViewPaymentTranBtn.Name = "ViewPaymentTranBtn";
            this.ViewPaymentTranBtn.Size = new System.Drawing.Size(139, 117);
            this.ViewPaymentTranBtn.TabIndex = 28;
            this.ViewPaymentTranBtn.Text = "View PaymentTran";
            this.ViewPaymentTranBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewPaymentTranBtn.UseVisualStyleBackColor = false;
            this.ViewPaymentTranBtn.Click += new System.EventHandler(this.ViewPaymentTranBtn_Click);
            // 
            // ViewAuthorListBtn
            // 
            this.ViewAuthorListBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewAuthorListBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAuthorListBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewAuthorListBtn.Image")));
            this.ViewAuthorListBtn.Location = new System.Drawing.Point(283, 187);
            this.ViewAuthorListBtn.Name = "ViewAuthorListBtn";
            this.ViewAuthorListBtn.Size = new System.Drawing.Size(139, 117);
            this.ViewAuthorListBtn.TabIndex = 29;
            this.ViewAuthorListBtn.Text = "View Author List";
            this.ViewAuthorListBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewAuthorListBtn.UseVisualStyleBackColor = false;
            this.ViewAuthorListBtn.Click += new System.EventHandler(this.ViewAuthorListBtn_Click);
            // 
            // ViewPublisherListbtn
            // 
            this.ViewPublisherListbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewPublisherListbtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPublisherListbtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewPublisherListbtn.Image")));
            this.ViewPublisherListbtn.Location = new System.Drawing.Point(428, 187);
            this.ViewPublisherListbtn.Name = "ViewPublisherListbtn";
            this.ViewPublisherListbtn.Size = new System.Drawing.Size(139, 117);
            this.ViewPublisherListbtn.TabIndex = 30;
            this.ViewPublisherListbtn.Text = "View Publisher List";
            this.ViewPublisherListbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewPublisherListbtn.UseVisualStyleBackColor = false;
            this.ViewPublisherListbtn.Click += new System.EventHandler(this.ViewPublisherListbtn_Click);
            // 
            // ViewCountryListBtn
            // 
            this.ViewCountryListBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewCountryListBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCountryListBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewCountryListBtn.Image")));
            this.ViewCountryListBtn.Location = new System.Drawing.Point(573, 187);
            this.ViewCountryListBtn.Name = "ViewCountryListBtn";
            this.ViewCountryListBtn.Size = new System.Drawing.Size(139, 117);
            this.ViewCountryListBtn.TabIndex = 31;
            this.ViewCountryListBtn.Text = "View Country List";
            this.ViewCountryListBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewCountryListBtn.UseVisualStyleBackColor = false;
            this.ViewCountryListBtn.Click += new System.EventHandler(this.ViewCountryListBtn_Click);
            // 
            // StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 741);
            this.Controls.Add(this.ViewCountryListBtn);
            this.Controls.Add(this.ViewPublisherListbtn);
            this.Controls.Add(this.ViewAuthorListBtn);
            this.Controls.Add(this.ViewPaymentTranBtn);
            this.Controls.Add(this.ViewIssueTranBtn);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.GetReportBtn);
            this.Controls.Add(this.ViewExtentionAppBtn);
            this.Controls.Add(this.ViewCusListBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ViewBookListBtn);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ChangePasswordbtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.StaffNameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffHome";
            this.Load += new System.EventHandler(this.StaffHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ChangePasswordbtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewBookListBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button ViewCusListBtn;
        private System.Windows.Forms.Button ViewExtentionAppBtn;
        private System.Windows.Forms.Button GetReportBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ViewIssueTranBtn;
        private System.Windows.Forms.Button ViewPaymentTranBtn;
        private System.Windows.Forms.Button ViewAuthorListBtn;
        private System.Windows.Forms.Button ViewPublisherListbtn;
        private System.Windows.Forms.Button ViewCountryListBtn;
    }
}