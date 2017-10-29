namespace Login
{
    partial class ManagePublisherInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePublisherInfo));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CusNameLabel = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 28);
            this.comboBox1.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 134;
            this.label2.Text = "Country  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 133;
            this.label4.Text = "Publisher Name :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(223, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 132;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CusNameLabel
            // 
            this.CusNameLabel.AutoSize = true;
            this.CusNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CusNameLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusNameLabel.Location = new System.Drawing.Point(125, 46);
            this.CusNameLabel.Name = "CusNameLabel";
            this.CusNameLabel.Size = new System.Drawing.Size(282, 31);
            this.CusNameLabel.TabIndex = 131;
            this.CusNameLabel.Text = "Manage Publisher Info";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(284, 118);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 30);
            this.textBox8.TabIndex = 130;
            // 
            // ManagePublisherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(555, 306);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CusNameLabel);
            this.Controls.Add(this.textBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagePublisherInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePublisherInfo";
            this.Load += new System.EventHandler(this.ManagePublisherInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CusNameLabel;
        private System.Windows.Forms.TextBox textBox8;
    }
}