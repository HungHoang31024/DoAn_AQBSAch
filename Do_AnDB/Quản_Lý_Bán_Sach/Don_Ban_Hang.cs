using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quản_Lý_Bán_Sach
{
    public partial class Don_Ban_Hang : Form
    {
        public Don_Ban_Hang()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLBSach");

        SqlDataAdapter daSach;
        SqlDataAdapter daHD;
        public void loadData()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBSach;Integrated Security=True";


            // Dữ liệu datagrid Sách 
            string sQueryHoaDon = @"select hd.*,s.TenSach,s.DonGia from HOADON hd,SACH s where hd.MaSach=s.MaSach ";
            daHD = new SqlDataAdapter(sQueryHoaDon, conn);
            daHD.Fill(ds, "tblDSHOADON");
            dgvHD.DataSource = ds.Tables["tblDSHOADON"];

            dgvHD.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
            dgvHD.Columns["MaHD"].Width = 100;

            dgvHD.Columns["NgayBan"].HeaderText = "Ngày Bán";
            dgvHD.Columns["NgayBan"].Width = 150;


            dgvHD.Columns["SLMua"].HeaderText = "Số Lương Mua";
            dgvHD.Columns["SLMua"].Width = 150;

            dgvHD.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvHD.Columns["ThanhTien"].Width = 150;

            dgvHD.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvHD.Columns["TenSach"].Width = 110;

            dgvHD.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvHD.Columns["DonGia"].Width = 110;






            string sThemHD = @"insert into HOADON values(@MaHD, @NgayBan, @SLMua, @ThanhTien, @MaSach)";
            SqlCommand cmThemHD = new SqlCommand(sThemHD, conn);
            cmThemHD.Parameters.Add("@MaHD", SqlDbType.Char, 5, "MaHD");
            cmThemHD.Parameters.Add("@NgayBan", SqlDbType.Date, 0, "NgayBan");
            cmThemHD.Parameters.Add("@SLMua", SqlDbType.SmallInt, 0, "SLMua");
            cmThemHD.Parameters.Add("@ThanhTien", SqlDbType.Int, 20, "ThanhTien");
            cmThemHD.Parameters.Add("@MaSach", SqlDbType.Char, 5, "MaSAch");
            daHD.InsertCommand = cmThemHD;
        }

        private void Don_Ban_Hang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvHD.SelectedRows[0];

            txtMaHD.Text = dr.Cells["MaHD"].Value.ToString();
            dtpNBan.Text = dr.Cells["NgayBan"].Value.ToString();
            txtSLMua.Text = dr.Cells["SLMua"].Value.ToString();
            txtTTien.Text = dr.Cells["ThanhTien"].Value.ToString();
            txtTenS.Text = dr.Cells["TenSach"].Value.ToString();
            txtDGia.Text = dr.Cells["DonGia"].Value.ToString();

        }
        public void ThanhTien()
        {
            string tt;
            int t1,t2, t3;
            t1 = int.Parse(txtSLMua.Text);
            t2 = int.Parse(txtDGia.Text);
            t3 = t1 * t2;
            tt = Convert.ToString(t3);
            this.txtTTien.Text = tt;
        }
        private void btnThemDSM_Click(object sender, EventArgs e)
        {
            ThanhTien();
            this.txtMaHD.Focus();
            ListViewItem item = lsvDSMHang.Items.Add(txtMaHD.Text);
            item.SubItems.Add(dtpNBan.Text.ToString());
            item.SubItems.Add(txtSLMua.Text.ToString());
            item.SubItems.Add(txtTTien.Text.ToString());
            item.SubItems.Add(txtTenS.Text.ToString());
            item.SubItems.Add(txtDGia.Text.ToString());

        }
        public void Sum()
        {
          /*  int s, s1, s2, s3, s4, s5, s6;
            int t, t1, t2, t3, t4, t5, t6;
            t1 = int.Parse(lsvDSMHang.SelectedItems[0].SubItems[3].Text);
            t2 = int.Parse(lsvDSMHang.SelectedItems[1].SubItems[3].Text);
            t3 = int.Parse(lsvDSMHang.SelectedItems[2].SubItems[3].Text);
            t4 = int.Parse(lsvDSMHang.SelectedItems[3].SubItems[3].Text);
            t5 = int.Parse(lsvDSMHang.SelectedItems[4].SubItems[3].Text);
            /*s1 = int.Parse(t1);
            s2 = int.Parse(t2);
            s3 = int.Parse(t3);
            s4 = int.Parse(t4);
            s5 = int.Parse(t5);*/
          /*  s = t1 + t2 + t3 + t4 + t5;
            string t7 = Convert.ToString(s);
            this.lblTongT.Text = t7;*/

            double sumTT = 0;
            for (int i = 0; i < lsvDSMHang.Items.Count; i++)
            {
                sumTT += double.Parse(lsvDSMHang.Items[i].SubItems[3].Text);
            }
            this.lblTongT.Text = sumTT.ToString();

        }


        private void btnTongT_Click(object sender, EventArgs e)
        {
            Sum();
        }
    }
}
