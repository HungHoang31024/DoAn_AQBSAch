using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Quản_Lý_Bán_Sach
{
    public partial class frmQLBS : Form
    {
        public frmQLBS()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void radQL_CheckedChanged(object sender, EventArgs e)
        {
            DangNhap Dn = new DangNhap();
            Dn.ShowDialog();
        }

        private void radNV_CheckedChanged(object sender, EventArgs e)
        {
            DangNhap Dn = new DangNhap();
            Dn.ShowDialog();
=======
        DataSet ds = new DataSet("dsQLBSach");

        SqlDataAdapter daSach;
        SqlDataAdapter daHD;
        BindingSource binding = null;
        public void loadData()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBSach;Integrated Security=True";


            // Dữ liệu datagrid Sách 
            string sQuerySach = @"select s.* from SACH s";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSACH");
            dgvSach.DataSource = ds.Tables["tblDSSACH"];
            
                        dgvSach.Columns["MaSach"].HeaderText = "Mã Sách";
                        dgvSach.Columns["MaSach"].Width = 100;

                        dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
                        dgvSach.Columns["TenSach"].Width = 150;


                        dgvSach.Columns["TacGia"].HeaderText = "Tác Giả";
                        dgvSach.Columns["TacGia"].Width = 150;

                        dgvSach.Columns["TenNSX"].HeaderText = "Tên Nhà Sản Xuất";
                        dgvSach.Columns["TenNSX"].Width = 150;

                        dgvSach.Columns["MaLoai"].HeaderText = "Mã Loại";
                        dgvSach.Columns["MaLoai"].Width = 110;

                        dgvSach.Columns["DonGia"].HeaderText = "Đơn Giá";
                        dgvSach.Columns["DonGia"].Width = 150;

                        dgvSach.Columns["SLTon"].HeaderText = "Số Lượng Tồn";
                        dgvSach.Columns["SLTon"].Width = 150;
            
                        dgvSach.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
                        dgvSach.Columns["NgayNhap"].Width = 100;

            string sThemS = @"insert into SACH values(@MaSach, @TenSach, @TacGia,@TenNSX, @MaLoai, @DonGia, @SLTon,@NgayNhap)";
            SqlCommand cmThemS = new SqlCommand(sThemS, conn);
            cmThemS.Parameters.Add("@MaSach", SqlDbType.Char, 20, "MaSach");
            cmThemS.Parameters.Add("@TenSach", SqlDbType.NVarChar, 40, "TenSach");
            cmThemS.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50, "TacGia");
            cmThemS.Parameters.Add("@TenNSX", SqlDbType.NVarChar, 20, "TenNSX");
            cmThemS.Parameters.Add("@MaLoai", SqlDbType.Char, 5, "MaLoai");
            cmThemS.Parameters.Add("@DonGia", SqlDbType.Int, 10, "DonGia");
            cmThemS.Parameters.Add("@SLTon", SqlDbType.SmallInt, 5, "SLTon");
            cmThemS.Parameters.Add("@NgayNhap", SqlDbType.Date, 0, "NgayNhap");
            daSach.InsertCommand = cmThemS;
        }
            private void btnThemS_Click(object sender, EventArgs e)
        {
            //Thêm TT Sách
            DataRow row = ds.Tables["tblDSSACH"].NewRow();
            row["MaSach"] = txtMSach.Text;
            row["TenSach"] = txtTSach.Text;
            row["TacGia"] = txtTGia.Text;
            row["TenNSX"] = txtNSXuat.Text;
            row["MaLoai"] = txtMLoai.Text;
            row["DonGia"] = txtĐGia.Text;
            row["SLTon"] = txtSLCon.Text;
            row["NgayNhap"] = dtpNNhap.Text;

            ds.Tables["tblDSSACH"].Rows.Add(row);
        }

        private void frmQLBS_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvSach.SelectedRows[0];

            txtMSach.Text = dr.Cells["MaSach"].Value.ToString();
            txtTSach.Text = dr.Cells["TenSach"].Value.ToString();
            txtTGia.Text = dr.Cells["TacGia"].Value.ToString();
            txtNSXuat.Text = dr.Cells["TenNSX"].Value.ToString();
            txtMLoai.Text = dr.Cells["MaLoai"].Value.ToString();
            txtĐGia.Text = dr.Cells["DonGia"].Value.ToString();
            txtSLCon.Text = dr.Cells["SLTon"].Value.ToString();
            dtpNNhap.Text = dr.Cells["NgayNhap"].Value.ToString();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
               if (dgvSach.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvSach.SelectedRows[0];
                dr.Cells["MaSach"].Value = txtMSach.Text;
                dr.Cells["TenSach"].Value = txtTSach.Text;
                dr.Cells["TacGia"].Value = txtTGia.Text;
                dr.Cells["MaLoai"].Value = txtMLoai.Text;
                dr.Cells["TenNSX"].Value = txtNSXuat.Text;
                dr.Cells["DonGia"].Value = txtĐGia.Text;
                dr.Cells["SLTon"].Value = txtSLCon.Text;
                dr.Cells["NgayNhap"].Value = dtpNNhap.Text;
                ds.Tables["tblDSSach"].Rows.Add(dr);
            }
            else
            {
                MessageBox.Show("Yêu cầu chọn sách");
            }
        }

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            /* this.txtMSach.ResetText();
             this.txtTSach.ResetText();
             this.txtTGia.ResetText();
             this.txtNSXuat.ResetText();
             this.txtĐGia.ResetText();

             this.txtSLCon.ResetText();

             this.txtMLoai.ResetText();
             this.dtpNNhap.ResetText();

             foreach (DataGridViewRow dr in this.dgvSach.SelectedRows)
             {
                 this.dgvSach.Rows.RemoveAt(dr.Index);
             }*/
            // No row selected no delete....
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
>>>>>>> 1af0e663608680e5fce6baeaae0876ad8abe9225
        }
    }
}