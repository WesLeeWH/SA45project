namespace Login
{
    partial class Changepassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changepassword));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OldPassword_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPassword_textbox = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "OldPassword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName";
            // 
            // OldPassword_textBox
            // 
            this.OldPassword_textBox.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldPassword_textBox.Location = new System.Drawing.Point(201, 165);
            this.OldPassword_textBox.Name = "OldPassword_textBox";
            this.OldPassword_textBox.Size = new System.Drawing.Size(209, 38);
            this.OldPassword_textBox.TabIndex = 7;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Username_textBox.Location = new System.Drawing.Point(201, 96);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(209, 38);
            this.Username_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "NewPassword";
            // 
            // NewPassword_textbox
            // 
            this.NewPassword_textbox.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPassword_textbox.Location = new System.Drawing.Point(201, 244);
            this.NewPassword_textbox.Name = "NewPassword_textbox";
            this.NewPassword_textbox.Size = new System.Drawing.Size(209, 38);
            this.NewPassword_textbox.TabIndex = 11;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConfirmBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.Location = new System.Drawing.Point(145, 317);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(133, 46);
            this.ConfirmBtn.TabIndex = 12;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Update Your Password";
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(444, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.NewPassword_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldPassword_textBox);
            this.Controls.Add(this.Username_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Changepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changepassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OldPassword_textBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPassword_textbox;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label4;
    }
}