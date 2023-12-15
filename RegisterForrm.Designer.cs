namespace WinFormsApp2
{
    partial class RegisterForrm
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
            btRegis = new Button();
            txbPassword = new TextBox();
            label2 = new Label();
            txbEmail = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txbFullName = new TextBox();
            label4 = new Label();
            txbPhone = new TextBox();
            label5 = new Label();
            btCancel = new Button();
            SuspendLayout();
            // 
            // btRegis
            // 
            btRegis.BackColor = Color.FromArgb(192, 255, 192);
            btRegis.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btRegis.Location = new Point(123, 237);
            btRegis.Name = "btRegis";
            btRegis.Size = new Size(80, 29);
            btRegis.TabIndex = 5;
            btRegis.Text = "Submit";
            btRegis.UseVisualStyleBackColor = false;
            btRegis.Click += btRegis_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(123, 119);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(202, 23);
            txbPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 127);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(123, 77);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(202, 23);
            txbEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 85);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 165);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Full Name:";
            // 
            // txbFullName
            // 
            txbFullName.Location = new Point(123, 157);
            txbFullName.Name = "txbFullName";
            txbFullName.Size = new Size(202, 23);
            txbFullName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 203);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(123, 195);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(202, 23);
            txbPhone.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(123, 9);
            label5.Name = "label5";
            label5.Size = new Size(175, 37);
            label5.TabIndex = 6;
            label5.Text = "Registration";
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.Red;
            btCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btCancel.Location = new Point(230, 237);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(84, 29);
            btCancel.TabIndex = 7;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // RegisterForrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 293);
            Controls.Add(btCancel);
            Controls.Add(label5);
            Controls.Add(btRegis);
            Controls.Add(txbPhone);
            Controls.Add(txbFullName);
            Controls.Add(label4);
            Controls.Add(txbPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbEmail);
            Controls.Add(label1);
            Name = "RegisterForrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForrm";
            Load += RegisterForrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRegis;
        private TextBox txbPassword;
        private Label label2;
        private TextBox txbEmail;
        private Label label1;
        private Label label3;
        private TextBox txbFullName;
        private Label label4;
        private TextBox txbPhone;
        private Label label5;
        private Button btCancel;
    }
}