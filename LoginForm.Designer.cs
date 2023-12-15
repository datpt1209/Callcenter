namespace WinFormsApp2
{
    partial class LoginForm
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
            label1 = new Label();
            txbEmail = new TextBox();
            btCancel = new Button();
            label2 = new Label();
            txbPassword = new TextBox();
            btLogin = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 98);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Username: ";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(134, 90);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(202, 23);
            txbEmail.TabIndex = 1;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.Red;
            btCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCancel.Location = new Point(237, 174);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(84, 33);
            btCancel.TabIndex = 4;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 140);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(134, 132);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(202, 23);
            txbPassword.TabIndex = 2;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Cyan;
            btLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.Location = new Point(134, 174);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(80, 33);
            btLogin.TabIndex = 3;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(134, 221);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registration here!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(171, 9);
            label3.Name = "label3";
            label3.Size = new Size(104, 45);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // LoginForm
            // 
            AcceptButton = btLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 271);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(btLogin);
            Controls.Add(btCancel);
            Controls.Add(txbPassword);
            Controls.Add(label2);
            Controls.Add(txbEmail);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbEmail;
        private Button btCancel;
        private Label label2;
        private TextBox txbPassword;
        private Button btLogin;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}