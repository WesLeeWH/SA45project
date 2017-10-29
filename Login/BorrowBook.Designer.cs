namespace Login
{
    partial class BorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BorrowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrow Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book List :";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SearchBox.Location = new System.Drawing.Point(105, 95);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(510, 31);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.Enter += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBtn.Location = new System.Drawing.Point(623, 94);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(119, 36);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(713, 212);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GetAvaliableDate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(71, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "From";
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromdateTimePicker.Location = new System.Drawing.Point(172, 423);
            this.FromdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(265, 21);
            this.FromdateTimePicker.TabIndex = 10;
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodateTimePicker.Location = new System.Drawing.Point(523, 423);
            this.TodateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.Size = new System.Drawing.Size(265, 21);
            this.TodateTimePicker.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(463, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "To";
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorrowBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("BorrowBtn.Image")));
            this.BorrowBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BorrowBtn.Location = new System.Drawing.Point(352, 477);
            this.BorrowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(202, 155);
            this.BorrowBtn.TabIndex = 13;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrowBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrowBtn.UseVisualStyleBackColor = false;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 661);
            this.Controls.Add(this.BorrowBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TodateTimePicker);
            this.Controls.Add(this.FromdateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBook";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BorrowBtn;
        //private System.Windows.Forms.BindingSource authorBindingSource;
    }
}