namespace DiemSinhVien
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            ListViewItem listViewItem19 = new ListViewItem("MaSV");
            ListViewItem listViewItem20 = new ListViewItem("Họ Tên");
            ListViewItem listViewItem21 = new ListViewItem("Tiếng Anh");
            ListViewItem listViewItem22 = new ListViewItem("Tin Học");
            ListViewItem listViewItem23 = new ListViewItem("GDTC");
            ListViewItem listViewItem24 = new ListViewItem("Điểm TB");
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtMaSV = new TextBox();
            lstDanhSachDiem = new ListView();
            label3 = new Label();
            grDiem = new GroupBox();
            txtDiemTB = new TextBox();
            label9 = new Label();
            txtGDTC = new TextBox();
            txtTinHoc = new TextBox();
            txtTiengAnh = new TextBox();
            txtMa = new TextBox();
            txtTen = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBox1.SuspendLayout();
            grDiem.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 30);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 1;
            label2.Text = "Quản lý điểm sinh viên ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(57, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 106);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm ";
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(627, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(111, 42);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(486, 27);
            txtMaSV.TabIndex = 1;
           // txtMaSV.TextChanged += txtMaSV_TextChanged;
            // 
            // lstDanhSachDiem
            // 
            lstDanhSachDiem.Items.AddRange(new ListViewItem[] { listViewItem19, listViewItem20, listViewItem21, listViewItem22, listViewItem23, listViewItem24 });
            lstDanhSachDiem.Location = new Point(57, 434);
            lstDanhSachDiem.Name = "lstDanhSachDiem";
            lstDanhSachDiem.Size = new Size(811, 115);
            lstDanhSachDiem.TabIndex = 3;
            lstDanhSachDiem.UseCompatibleStateImageBehavior = false;
            lstDanhSachDiem.SelectedIndexChanged += lstDanhSachDiem_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 415);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 4;
            label3.Text = "3 Sinh Viên có điểm cao nhất ";
            // 
            // grDiem
            // 
            grDiem.Controls.Add(txtDiemTB);
            grDiem.Controls.Add(label9);
            grDiem.Controls.Add(txtGDTC);
            grDiem.Controls.Add(txtTinHoc);
            grDiem.Controls.Add(txtTiengAnh);
            grDiem.Controls.Add(txtMa);
            grDiem.Controls.Add(txtTen);
            grDiem.Controls.Add(label8);
            grDiem.Controls.Add(label7);
            grDiem.Controls.Add(label6);
            grDiem.Controls.Add(label5);
            grDiem.Controls.Add(label4);
            grDiem.Location = new Point(57, 175);
            grDiem.Name = "grDiem";
            grDiem.Size = new Size(563, 237);
            grDiem.TabIndex = 5;
            grDiem.TabStop = false;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(353, 135);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(173, 27);
            txtDiemTB.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(409, 112);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 10;
            label9.Text = "DiemTB";
            // 
            // txtGDTC
            // 
            txtGDTC.Location = new Point(121, 193);
            txtGDTC.Name = "txtGDTC";
            txtGDTC.Size = new Size(125, 27);
            txtGDTC.TabIndex = 9;
            // 
            // txtTinHoc
            // 
            txtTinHoc.Location = new Point(121, 150);
            txtTinHoc.Name = "txtTinHoc";
            txtTinHoc.Size = new Size(125, 27);
            txtTinHoc.TabIndex = 8;
            // 
            // txtTiengAnh
            // 
            txtTiengAnh.Location = new Point(121, 105);
            txtTiengAnh.Name = "txtTiengAnh";
            txtTiengAnh.Size = new Size(125, 27);
            txtTiengAnh.TabIndex = 7;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(121, 61);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(239, 27);
            txtMa.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(121, 28);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(239, 27);
            txtTen.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 200);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 4;
            label8.Text = "GDTC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 157);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 3;
            label7.Text = "TinHoc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 112);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 2;
            label6.Text = "TiengAnh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 69);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 1;
            label5.Text = "Mã SV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 35);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Họ Tên SV";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(735, 184);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 6;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(735, 244);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(735, 304);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(735, 366);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 547);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(grDiem);
            Controls.Add(label3);
            Controls.Add(lstDanhSachDiem);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grDiem.ResumeLayout(false);
            grDiem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtMaSV;
        private ListView lstDanhSachDiem;
        private Label label3;
        private GroupBox grDiem;
        private Label label9;
        private TextBox txtGDTC;
        private TextBox txtTinHoc;
        private TextBox txtTiengAnh;
        private TextBox txtMa;
        private TextBox txtTen;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtDiemTB;
    }
}