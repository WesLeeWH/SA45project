namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Titile = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Tan;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Location = new System.Drawing.Point(377, 237);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(162, 44);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Username_textBox
            // 
            this.Username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_textBox.Font = new System.Drawing.Font("SimSun", 15F);
            this.Username_textBox.Location = new System.Drawing.Point(377, 107);
            this.Username_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(277, 23);
            this.Username_textBox.TabIndex = 1;
            this.Username_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_textBox_KeyDown);
            // 
            // Titile
            // 
            this.Titile.AutoSize = true;
            this.Titile.BackColor = System.Drawing.Color.Transparent;
            this.Titile.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titile.ForeColor = System.Drawing.Color.Tan;
            this.Titile.Location = new System.Drawing.Point(193, 31);
            this.Titile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titile.Name = "Titile";
            this.Titile.Size = new System.Drawing.Size(499, 38);
            this.Titile.TabIndex = 2;
            this.Titile.Text = "Library Management System";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("SimSun", 15F);
            this.Password_textBox.Location = new System.Drawing.Point(377, 159);
            this.Password_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(277, 30);
            this.Password_textBox.TabIndex = 3;
            this.Password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_textBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(205, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(205, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BackColor = System.Drawing.Color.Transparent;
            this.Message.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Message.ForeColor = System.Drawing.Color.Tomato;
            this.Message.Location = new System.Drawing.Point(410, 204);
            this.Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(86, 20);
            this.Message.TabIndex = 6;
            this.Message.Text = "Welcome";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 551);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Titile);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.LoginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label Titile;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Message;
    }
}

