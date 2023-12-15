namespace WinFormsApp2
{
    partial class MainForm
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
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbSdt = new TextBox();
            label4 = new Label();
            txbphuongdi = new TextBox();
            label5 = new Label();
            txbquandi = new TextBox();
            label6 = new Label();
            txtTinhdi = new TextBox();
            lbOriginAddress = new Label();
            groupBox1 = new GroupBox();
            VIP = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            listView1 = new ListView();
            STT = new ColumnHeader();
            UserName = new ColumnHeader();
            Phone = new ColumnHeader();
            Time = new ColumnHeader();
            Origin = new ColumnHeader();
            Destination = new ColumnHeader();
            label8 = new Label();
            txbSonhadi = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txbPhuongDen = new TextBox();
            txbSonhaDen = new TextBox();
            txbQuanDen = new TextBox();
            txbTinhDen = new TextBox();
            lbDestinationAddress = new Label();
            btDieuphoi = new Button();
            label14 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 96);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Số điện thoại:";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 203);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Số nhà:";
            // 
            // txbSdt
            // 
            txbSdt.Location = new Point(129, 88);
            txbSdt.Name = "txbSdt";
            txbSdt.Size = new Size(256, 23);
            txbSdt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 232);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 0;
            label4.Text = "Phường:";
            // 
            // txbphuongdi
            // 
            txbphuongdi.Location = new Point(127, 224);
            txbphuongdi.Name = "txbphuongdi";
            txbphuongdi.Size = new Size(256, 23);
            txbphuongdi.TabIndex = 4;
            txbphuongdi.TextChanged += txbphuongdi_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 261);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Quận:";
            // 
            // txbquandi
            // 
            txbquandi.Location = new Point(127, 253);
            txbquandi.Name = "txbquandi";
            txbquandi.Size = new Size(256, 23);
            txbquandi.TabIndex = 5;
            txbquandi.TextChanged += txbquandi_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 290);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 0;
            label6.Text = "Tỉnh";
            // 
            // txtTinhdi
            // 
            txtTinhdi.Location = new Point(127, 282);
            txtTinhdi.Name = "txtTinhdi";
            txtTinhdi.Size = new Size(256, 23);
            txtTinhdi.TabIndex = 6;
            txtTinhdi.TextChanged += txtTinhdi_TextChanged;
            // 
            // lbOriginAddress
            // 
            lbOriginAddress.BackColor = SystemColors.Info;
            lbOriginAddress.Location = new Point(13, 129);
            lbOriginAddress.Name = "lbOriginAddress";
            lbOriginAddress.Size = new Size(370, 52);
            lbOriginAddress.TabIndex = 2;
            lbOriginAddress.Text = "Địa chỉ đón";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(VIP);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(464, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 66);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại xe";
            // 
            // VIP
            // 
            VIP.AutoSize = true;
            VIP.Location = new Point(226, 31);
            VIP.Name = "VIP";
            VIP.Size = new Size(42, 19);
            VIP.TabIndex = 4;
            VIP.TabStop = true;
            VIP.Text = "VIP";
            VIP.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(116, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "7 chỗ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "4 chỗ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Columns.AddRange(new ColumnHeader[] { STT, UserName, Phone, Time, Origin, Destination });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(13, 344);
            listView1.Name = "listView1";
            listView1.Size = new Size(845, 225);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 40;
            // 
            // UserName
            // 
            UserName.Text = "Khách Hàng";
            UserName.Width = 100;
            // 
            // Phone
            // 
            Phone.Text = "Số điện thoại";
            Phone.Width = 100;
            // 
            // Time
            // 
            Time.Text = "Thời gian";
            Time.Width = 100;
            // 
            // Origin
            // 
            Origin.Text = "Điểm đi";
            Origin.Width = 250;
            // 
            // Destination
            // 
            Destination.Text = "Điểm đến";
            Destination.Width = 250;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 326);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 0;
            label8.Text = "Các cuộc gọi gần nhất";
            // 
            // txbSonhadi
            // 
            txbSonhadi.Location = new Point(129, 195);
            txbSonhadi.Name = "txbSonhadi";
            txbSonhadi.Size = new Size(256, 23);
            txbSonhadi.TabIndex = 3;
            txbSonhadi.TextChanged += txbSonhadi_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(464, 203);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 0;
            label9.Text = "Số nhà:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(464, 232);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 0;
            label10.Text = "Phường:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(464, 261);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 0;
            label11.Text = "Quận:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(464, 290);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 0;
            label12.Text = "Tỉnh";
            // 
            // txbPhuongDen
            // 
            txbPhuongDen.Location = new Point(578, 224);
            txbPhuongDen.Name = "txbPhuongDen";
            txbPhuongDen.Size = new Size(256, 23);
            txbPhuongDen.TabIndex = 8;
            txbPhuongDen.TextChanged += txbPhuongDen_TextChanged;
            // 
            // txbSonhaDen
            // 
            txbSonhaDen.Location = new Point(580, 195);
            txbSonhaDen.Name = "txbSonhaDen";
            txbSonhaDen.Size = new Size(256, 23);
            txbSonhaDen.TabIndex = 7;
            txbSonhaDen.TextChanged += txbSonhaDen_TextChanged;
            // 
            // txbQuanDen
            // 
            txbQuanDen.Location = new Point(578, 253);
            txbQuanDen.Name = "txbQuanDen";
            txbQuanDen.Size = new Size(256, 23);
            txbQuanDen.TabIndex = 9;
            txbQuanDen.TextChanged += txbQuanDen_TextChanged;
            // 
            // txbTinhDen
            // 
            txbTinhDen.Location = new Point(578, 282);
            txbTinhDen.Name = "txbTinhDen";
            txbTinhDen.Size = new Size(256, 23);
            txbTinhDen.TabIndex = 10;
            txbTinhDen.TextChanged += txbTinhDen_TextChanged;
            // 
            // lbDestinationAddress
            // 
            lbDestinationAddress.BackColor = SystemColors.Info;
            lbDestinationAddress.Location = new Point(462, 129);
            lbDestinationAddress.Name = "lbDestinationAddress";
            lbDestinationAddress.Size = new Size(370, 52);
            lbDestinationAddress.TabIndex = 2;
            lbDestinationAddress.Text = "Địa chỉ điểm đến";
            // 
            // btDieuphoi
            // 
            btDieuphoi.BackColor = Color.Lime;
            btDieuphoi.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btDieuphoi.Location = new Point(335, 575);
            btDieuphoi.Name = "btDieuphoi";
            btDieuphoi.Size = new Size(140, 33);
            btDieuphoi.TabIndex = 11;
            btDieuphoi.Text = "Điều phối";
            btDieuphoi.UseMnemonic = false;
            btDieuphoi.UseVisualStyleBackColor = false;
            btDieuphoi.Click += btDieuphoi_Click;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(128, 255, 255);
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(15, 9);
            label14.Name = "label14";
            label14.Size = new Size(821, 39);
            label14.TabIndex = 6;
            label14.Text = "HỆ THỐNG TỔNG ĐÀI ĐIỀU PHỐI TAXI";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 620);
            Controls.Add(label14);
            Controls.Add(btDieuphoi);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(lbDestinationAddress);
            Controls.Add(lbOriginAddress);
            Controls.Add(txbTinhDen);
            Controls.Add(txtTinhdi);
            Controls.Add(txbQuanDen);
            Controls.Add(txbquandi);
            Controls.Add(txbSonhaDen);
            Controls.Add(txbPhuongDen);
            Controls.Add(txbSonhadi);
            Controls.Add(txbphuongdi);
            Controls.Add(txbSdt);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txbSdt;
        private Label label4;
        private TextBox txbphuongdi;
        private Label label5;
        private TextBox txbquandi;
        private Label label6;
        private TextBox txtTinhdi;
        private Label lbOriginAddress;
        private GroupBox groupBox1;
        private RadioButton VIP;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListView listView1;
        private Label label8;
        private TextBox txbSonhadi;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txbPhuongDen;
        private TextBox txbSonhaDen;
        private TextBox txbQuanDen;
        private TextBox txbTinhDen;
        private Label lbDestinationAddress;
        private ColumnHeader STT;
        private ColumnHeader UserName;
        private ColumnHeader Time;
        private ColumnHeader Origin;
        private ColumnHeader Destination;
        private Button btDieuphoi;
        private Label label14;
        private ColumnHeader Phone;
    }
}