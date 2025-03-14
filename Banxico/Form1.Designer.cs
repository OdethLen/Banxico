namespace Banxico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPasword = new TextBox();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnLogin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F);
            label1.Location = new Point(84, 45);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F);
            label2.Location = new Point(57, 89);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Pasword";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Yu Gothic UI", 11.25F);
            txtUser.Location = new Point(130, 45);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(157, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPasword
            // 
            txtPasword.Font = new Font("Yu Gothic UI", 11.25F);
            txtPasword.Location = new Point(130, 98);
            txtPasword.Name = "txtPasword";
            txtPasword.PasswordChar = '*';
            txtPasword.Size = new Size(157, 27);
            txtPasword.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPasword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(133, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 152);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Yu Gothic UI", 9.75F);
            btnClose.Location = new Point(217, 234);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 40);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Yu Gothic UI", 9.75F);
            btnLogin.Location = new Point(330, 234);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 315);
            Controls.Add(btnLogin);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPasword;
        private GroupBox groupBox1;
        private Button btnClose;
        private Button btnLogin;
    }
}
