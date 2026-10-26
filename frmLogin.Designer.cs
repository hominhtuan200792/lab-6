namespace quanlyhocsinh
{
    partial class frmLogin
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
            txtUsername = new Label();
            txtPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Location = new Point(82, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(80, 20);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "đăng nhập";
            
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Location = new Point(82, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(70, 20);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(457, 138);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(457, 185);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUsername;
        private Label txtPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}