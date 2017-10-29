namespace Login
{
    partial class CusHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CusHome));
            this.label1 = new System.Windows.Forms.Label();
            this.CusNameLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ChangePasswordbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactiondataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.BorrowBookBtn = new System.Windows.Forms.Button();
            this.ExtendLoanBtn = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactiondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // CusNameLabel
            // 
            this.CusNameLabel.AutoSize = true;
            this.CusNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CusNameLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusNameLabel.Location = new System.Drawing.Point(173, 18);
            this.CusNameLabel.Name = "CusNameLabel";
            this.CusNameLabel.Size = new System.Drawing.Size(230, 36);
            this.CusNameLabel.TabIndex = 1;
            this.CusNameLabel.Text = "CustomerName";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(536, 29);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ChangePasswordbtn
            // 
            this.ChangePasswordbtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordbtn.Location = new System.Drawing.Point(416, 29);
            this.ChangePasswordbtn.Name = "ChangePasswordbtn";
            this.ChangePasswordbtn.Size = new System.Drawing.Size(104, 23);
            this.ChangePasswordbtn.TabIndex = 3;
            this.ChangePasswordbtn.Text = "ChangePassword";
            this.ChangePasswordbtn.UseVisualStyleBackColor = true;
            this.ChangePasswordbtn.Click += new System.EventHandler(this.ChangePasswordbtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "My Transaction:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TransactiondataGridView
            // 
            this.TransactiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactiondataGridView.Location = new System.Drawing.Point(26, 121);
            this.TransactiondataGridView.Name = "TransactiondataGridView";
            this.TransactiondataGridView.RowTemplate.Height = 23;
            this.TransactiondataGridView.Size = new System.Drawing.Size(585, 141);
            this.TransactiondataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(160, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 49);
            this.label3.TabIndex = 6;
            this.label3.Text = "What do you wish to do ?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ReturnBookBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReturnBookBtn.Image")));
            this.ReturnBookBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReturnBookBtn.Location = new System.Drawing.Point(61, 350);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(115, 93);
            this.ReturnBookBtn.TabIndex = 7;
            this.ReturnBookBtn.Text = "Return Book";
            this.ReturnBookBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReturnBookBtn.UseVisualStyleBackColor = false;
            this.ReturnBookBtn.Click += new System.EventHandler(this.ReturnBookBtn_Click);
            // 
            // BorrowBookBtn
            // 
            this.BorrowBookBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.BorrowBookBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("BorrowBookBtn.Image")));
            this.BorrowBookBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BorrowBookBtn.Location = new System.Drawing.Point(268, 350);
            this.BorrowBookBtn.Name = "BorrowBookBtn";
            this.BorrowBookBtn.Size = new System.Drawing.Size(115, 93);
            this.BorrowBookBtn.TabIndex = 8;
            this.BorrowBookBtn.Text = "Borrow Book";
            this.BorrowBookBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrowBookBtn.UseVisualStyleBackColor = false;
            this.BorrowBookBtn.Click += new System.EventHandler(this.BorrowBookBtn_Click);
            // 
            // ExtendLoanBtn
            // 
            this.ExtendLoanBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ExtendLoanBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtendLoanBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExtendLoanBtn.Image")));
            this.ExtendLoanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExtendLoanBtn.Location = new System.Drawing.Point(467, 350);
            this.ExtendLoanBtn.Name = "ExtendLoanBtn";
            this.ExtendLoanBtn.Size = new System.Drawing.Size(115, 93);
            this.ExtendLoanBtn.TabIndex = 9;
            this.ExtendLoanBtn.Text = "Extend the loan";
            this.ExtendLoanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExtendLoanBtn.UseVisualStyleBackColor = false;
            this.ExtendLoanBtn.Click += new System.EventHandler(this.ExtendLoanBtn_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Location = new System.Drawing.Point(38, 53);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(29, 12);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Date";
            // 
            // CusHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 496);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ExtendLoanBtn);
            this.Controls.Add(this.BorrowBookBtn);
            this.Controls.Add(this.ReturnBookBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransactiondataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangePasswordbtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CusNameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CusHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.CusHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactiondataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CusNameLabel;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ChangePasswordbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TransactiondataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReturnBookBtn;
        private System.Windows.Forms.Button BorrowBookBtn;
        private System.Windows.Forms.Button ExtendLoanBtn;
        private System.Windows.Forms.Label DateLabel;
    }
}