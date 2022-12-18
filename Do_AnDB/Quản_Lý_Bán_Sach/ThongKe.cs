using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Bán_Sach
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLBSach");
        SqlDataAdapter daSach;
        public void loadData()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBSach;Integrated Security=True";

            // Dữ liệu datagrid Sách 
            string sQuerySach = @"select MaSach, TenSach, TacGia, TenNSX, MaLoai, DonGia, SLTon, NgayNhap  from SACH";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSACH");
            dtgThongKeSach.DataSource = ds.Tables["tblDSSACH"];



            dtgThongKeSach.Columns["MaSach"].HeaderText = "Mã Sách";
            dtgThongKeSach.Columns["MaSach"].Width = 90;
            this.dtgThongKeSach.Columns["MaSach"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["MaSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dtgThongKeSach.Columns["TenSach"].Width = 170;
            this.dtgThongKeSach.Columns["TenSach"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["TenSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["TacGia"].HeaderText = "Tác Giả";
            dtgThongKeSach.Columns["TacGia"].Width = 130;
            this.dtgThongKeSach.Columns["TacGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["TacGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["TenNSX"].HeaderText = "Tên NSX";
            dtgThongKeSach.Columns["TenNSX"].Width = 170;
            this.dtgThongKeSach.Columns["TenNSX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["TenNSX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["MaLoai"].HeaderText = "Mã Loại";
            dtgThongKeSach.Columns["MaLoai"].Width = 90;
            this.dtgThongKeSach.Columns["MaLoai"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["MaLoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["DonGia"].HeaderText = "Đơn Giá";
            dtgThongKeSach.Columns["DonGia"].Width = 150;
            this.dtgThongKeSach.Columns["DonGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["SLTon"].HeaderText = "SL Tồn";
            dtgThongKeSach.Columns["SLTon"].Width = 60;
            this.dtgThongKeSach.Columns["SLTon"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["SLTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dtgThongKeSach.Columns["NgayNhap"].Width = 130;
            this.dtgThongKeSach.Columns["NgayNhap"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            string sThemS = @"insert into Sach values(@MaSach, @TenSach, @TacGia,@TenNSX, @MaLoai, @DonGia, @SLTon, @NgayNhap)";
            SqlCommand cmThemS = new SqlCommand(sThemS, conn);
            cmThemS.Parameters.Add("@MaSach", SqlDbType.Char, 20, "MaSach");
            cmThemS.Parameters.Add("@TenSach", SqlDbType.NVarChar, 40, "TenSach");
            cmThemS.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50, "TacGia");
            cmThemS.Parameters.Add("@TenNSX", SqlDbType.NVarChar, 20, "TenNSX");
            cmThemS.Parameters.Add("@MaLoai", SqlDbType.Char, 5, "MaLoai");
            cmThemS.Parameters.Add("@DonGia", SqlDbType.Int, 10, "DonGia");
            cmThemS.Parameters.Add("@SLTon", SqlDbType.SmallInt, 5, "SLTon");
            cmThemS.Parameters.Add("@NgayNhap", SqlDbType.Date, 20, "NgayNhap");



            daSach.InsertCommand = cmThemS;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
