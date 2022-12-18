namespace Quản_Lý_Bán_Sach
{
    partial class frmQLBS
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLBS));
            this.radQL = new System.Windows.Forms.RadioButton();
            this.radNV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radQL
            // 
            this.radQL.AutoSize = true;
            this.radQL.BackColor = System.Drawing.Color.LightGray;
            this.radQL.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radQL.Location = new System.Drawing.Point(73, 34);
            this.radQL.Name = "radQL";
            this.radQL.Size = new System.Drawing.Size(143, 40);
            this.radQL.TabIndex = 2;
            this.radQL.TabStop = true;
            this.radQL.Text = "Quản lí";
            this.radQL.UseVisualStyleBackColor = false;
            this.radQL.CheckedChanged += new System.EventHandler(this.radQL_CheckedChanged);
            // 
            // radNV
            // 
            this.radNV.AutoSize = true;
            this.radNV.BackColor = System.Drawing.Color.LightGray;
            this.radNV.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radNV.Location = new System.Drawing.Point(73, 95);
            this.radNV.Name = "radNV";
            this.radNV.Size = new System.Drawing.Size(180, 40);
            this.radNV.TabIndex = 2;
            this.radNV.TabStop = true;
            this.radNV.Text = "Nhân viên";
            this.radNV.UseVisualStyleBackColor = false;
            this.radNV.CheckedChanged += new System.EventHandler(this.radNV_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radNV);
            this.groupBox1.Controls.Add(this.radQL);
            this.groupBox1.Location = new System.Drawing.Point(608, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
=======
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.grbTTSach = new System.Windows.Forms.GroupBox();
            this.dtpNNhap = new System.Windows.Forms.DateTimePicker();
            this.txtĐGia = new System.Windows.Forms.TextBox();
            this.txtMLoai = new System.Windows.Forms.TextBox();
            this.txtTGia = new System.Windows.Forms.TextBox();
            this.txtSLCon = new System.Windows.Forms.TextBox();
            this.txtNSXuat = new System.Windows.Forms.TextBox();
            this.txtTSach = new System.Windows.Forms.TextBox();
            this.txtMSach = new System.Windows.Forms.TextBox();
            this.lblSLCon = new System.Windows.Forms.Label();
            this.lblNNhap = new System.Windows.Forms.Label();
            this.lblDGia = new System.Windows.Forms.Label();
            this.lblMLoai = new System.Windows.Forms.Label();
            this.lblNSXuat = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenS = new System.Windows.Forms.Label();
            this.lblMaS = new System.Windows.Forms.Label();
            this.btnThemS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaS = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblQLBS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.grbTTSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(759, 121);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 33;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(914, 409);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // grbTTSach
            // 
            this.grbTTSach.Controls.Add(this.dtpNNhap);
            this.grbTTSach.Controls.Add(this.txtĐGia);
            this.grbTTSach.Controls.Add(this.txtMLoai);
            this.grbTTSach.Controls.Add(this.txtTGia);
            this.grbTTSach.Controls.Add(this.txtSLCon);
            this.grbTTSach.Controls.Add(this.txtNSXuat);
            this.grbTTSach.Controls.Add(this.txtTSach);
            this.grbTTSach.Controls.Add(this.txtMSach);
            this.grbTTSach.Controls.Add(this.lblSLCon);
            this.grbTTSach.Controls.Add(this.lblNNhap);
            this.grbTTSach.Controls.Add(this.lblDGia);
            this.grbTTSach.Controls.Add(this.lblMLoai);
            this.grbTTSach.Controls.Add(this.lblNSXuat);
            this.grbTTSach.Controls.Add(this.lblTacGia);
            this.grbTTSach.Controls.Add(this.lblTenS);
            this.grbTTSach.Controls.Add(this.lblMaS);
            this.grbTTSach.Location = new System.Drawing.Point(20, 106);
            this.grbTTSach.Name = "grbTTSach";
            this.grbTTSach.Size = new System.Drawing.Size(473, 424);
            this.grbTTSach.TabIndex = 2;
            this.grbTTSach.TabStop = false;
            this.grbTTSach.Text = "Thông Tin Sách";
            // 
            // dtpNNhap
            // 
            this.dtpNNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNhap.Location = new System.Drawing.Point(155, 363);
            this.dtpNNhap.Name = "dtpNNhap";
            this.dtpNNhap.Size = new System.Drawing.Size(312, 35);
            this.dtpNNhap.TabIndex = 2;
            // 
            // txtĐGia
            // 
            this.txtĐGia.Location = new System.Drawing.Point(112, 270);
            this.txtĐGia.Name = "txtĐGia";
            this.txtĐGia.Size = new System.Drawing.Size(353, 35);
            this.txtĐGia.TabIndex = 1;
            // 
            // txtMLoai
            // 
            this.txtMLoai.Location = new System.Drawing.Point(114, 225);
            this.txtMLoai.Name = "txtMLoai";
            this.txtMLoai.Size = new System.Drawing.Size(353, 35);
            this.txtMLoai.TabIndex = 1;
            // 
            // txtTGia
            // 
            this.txtTGia.Location = new System.Drawing.Point(114, 125);
            this.txtTGia.Name = "txtTGia";
            this.txtTGia.Size = new System.Drawing.Size(353, 35);
            this.txtTGia.TabIndex = 1;
            // 
            // txtSLCon
            // 
            this.txtSLCon.Location = new System.Drawing.Point(170, 318);
            this.txtSLCon.Name = "txtSLCon";
            this.txtSLCon.Size = new System.Drawing.Size(295, 35);
            this.txtSLCon.TabIndex = 1;
            // 
            // txtNSXuat
            // 
            this.txtNSXuat.Location = new System.Drawing.Point(155, 174);
            this.txtNSXuat.Name = "txtNSXuat";
            this.txtNSXuat.Size = new System.Drawing.Size(312, 35);
            this.txtNSXuat.TabIndex = 1;
            // 
            // txtTSach
            // 
            this.txtTSach.Location = new System.Drawing.Point(114, 80);
            this.txtTSach.Name = "txtTSach";
            this.txtTSach.Size = new System.Drawing.Size(353, 35);
            this.txtTSach.TabIndex = 1;
            // 
            // txtMSach
            // 
            this.txtMSach.Location = new System.Drawing.Point(114, 28);
            this.txtMSach.Name = "txtMSach";
            this.txtMSach.Size = new System.Drawing.Size(353, 35);
            this.txtMSach.TabIndex = 1;
            // 
            // lblSLCon
            // 
            this.lblSLCon.AutoSize = true;
            this.lblSLCon.Location = new System.Drawing.Point(8, 321);
            this.lblSLCon.Name = "lblSLCon";
            this.lblSLCon.Size = new System.Drawing.Size(158, 27);
            this.lblSLCon.TabIndex = 0;
            this.lblSLCon.Text = "Số Lượng Còn:";
            // 
            // lblNNhap
            // 
            this.lblNNhap.AutoSize = true;
            this.lblNNhap.Location = new System.Drawing.Point(8, 369);
            this.lblNNhap.Name = "lblNNhap";
            this.lblNNhap.Size = new System.Drawing.Size(127, 27);
            this.lblNNhap.TabIndex = 0;
            this.lblNNhap.Text = "Ngày Nhập:";
            // 
            // lblDGia
            // 
            this.lblDGia.AutoSize = true;
            this.lblDGia.Location = new System.Drawing.Point(6, 273);
            this.lblDGia.Name = "lblDGia";
            this.lblDGia.Size = new System.Drawing.Size(100, 27);
            this.lblDGia.TabIndex = 0;
            this.lblDGia.Text = "Đơn Giá:";
            // 
            // lblMLoai
            // 
            this.lblMLoai.AutoSize = true;
            this.lblMLoai.Location = new System.Drawing.Point(6, 225);
            this.lblMLoai.Name = "lblMLoai";
            this.lblMLoai.Size = new System.Drawing.Size(100, 27);
            this.lblMLoai.TabIndex = 0;
            this.lblMLoai.Text = "Mã Loại:";
            // 
            // lblNSXuat
            // 
            this.lblNSXuat.AutoSize = true;
            this.lblNSXuat.Location = new System.Drawing.Point(6, 177);
            this.lblNSXuat.Name = "lblNSXuat";
            this.lblNSXuat.Size = new System.Drawing.Size(152, 27);
            this.lblNSXuat.TabIndex = 0;
            this.lblNSXuat.Text = "Nhà Sản Xuất:";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(6, 128);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(94, 27);
            this.lblTacGia.TabIndex = 0;
            this.lblTacGia.Text = "Tác Giả:";
            // 
            // lblTenS
            // 
            this.lblTenS.AutoSize = true;
            this.lblTenS.Location = new System.Drawing.Point(6, 83);
            this.lblTenS.Name = "lblTenS";
            this.lblTenS.Size = new System.Drawing.Size(107, 27);
            this.lblTenS.TabIndex = 0;
            this.lblTenS.Text = "Tên Sách:";
            // 
            // lblMaS
            // 
            this.lblMaS.AutoSize = true;
            this.lblMaS.Location = new System.Drawing.Point(6, 31);
            this.lblMaS.Name = "lblMaS";
            this.lblMaS.Size = new System.Drawing.Size(102, 27);
            this.lblMaS.TabIndex = 0;
            this.lblMaS.Text = "Mã Sách:";
            // 
            // btnThemS
            // 
            this.btnThemS.Location = new System.Drawing.Point(527, 137);
            this.btnThemS.Name = "btnThemS";
            this.btnThemS.Size = new System.Drawing.Size(154, 59);
            this.btnThemS.TabIndex = 3;
            this.btnThemS.Text = "Thêm Sách";
            this.btnThemS.UseVisualStyleBackColor = true;
            this.btnThemS.Click += new System.EventHandler(this.btnThemS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Sách:";
            // 
            // btnXoaS
            // 
            this.btnXoaS.Location = new System.Drawing.Point(527, 363);
            this.btnXoaS.Name = "btnXoaS";
            this.btnXoaS.Size = new System.Drawing.Size(154, 59);
            this.btnXoaS.TabIndex = 3;
            this.btnXoaS.Text = "Xóa Sách";
            this.btnXoaS.UseVisualStyleBackColor = true;
            this.btnXoaS.Click += new System.EventHandler(this.btnXoaS_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(527, 251);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 59);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa Sách";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(527, 471);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 59);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblQLBS
            // 
            this.lblQLBS.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQLBS.ForeColor = System.Drawing.Color.Red;
            this.lblQLBS.Location = new System.Drawing.Point(647, 30);
            this.lblQLBS.Name = "lblQLBS";
            this.lblQLBS.Size = new System.Drawing.Size(385, 61);
            this.lblQLBS.TabIndex = 4;
            this.lblQLBS.Text = "QUẢN LÝ SÁCH";
            this.lblQLBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
>>>>>>> 1af0e663608680e5fce6baeaae0876ad8abe9225
            // 
            // frmQLBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQLBS";
            this.Text = "Người sử dung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
=======
            this.ClientSize = new System.Drawing.Size(1685, 553);
            this.Controls.Add(this.lblQLBS);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaS);
            this.Controls.Add(this.btnThemS);
            this.Controls.Add(this.grbTTSach);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQLBS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmQLBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.grbTTSach.ResumeLayout(false);
            this.grbTTSach.PerformLayout();
>>>>>>> 1af0e663608680e5fce6baeaae0876ad8abe9225
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private RadioButton radQL;
        private RadioButton radNV;
        private GroupBox groupBox1;
=======
        private DataGridView dgvSach;
        private GroupBox grbTTSach;
        private Button button;
        private Button btnThemS;
        private DateTimePicker dtpNNhap;
        private TextBox txtĐGia;
        private TextBox txtMLoai;
        private TextBox txtTGia;
        private TextBox txtSLCon;
        private TextBox txtNSXuat;
        private TextBox txtTSach;
        private TextBox txtMSach;
        private Label lblSLCon;
        private Label lblNNhap;
        private Label lblDGia;
        private Label lblMLoai;
        private Label lblNSXuat;
        private Label lblTacGia;
        private Label lblTenS;
        private Label lblMaS;
        private Label label5;
        private Button btnXoaS;
        private Button btnSua;
        private Button btnThoat;
        private Label lblQLBS;
>>>>>>> 1af0e663608680e5fce6baeaae0876ad8abe9225
    }
}