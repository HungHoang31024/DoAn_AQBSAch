using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Bán_Sach
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
                if ((this.txtTenTK.Text == "") || (this.txtMK.Text == ""))
                {

                    MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
                }
                else
                {
                    if ((this.txtTenTK.Text == "qlNhuQuynh") && (this.txtMK.Text == "9999."))
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        this.Close();
                        Chức_năng CN = new Chức_năng();
                        CN.ShowDialog();
                    }
                else if ((this.txtTenTK.Text == "NVQuynhCongChua") && (this.txtMK.Text == "9999."))
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        this.Close();
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }
                    else
                    {
                        if (this.radGN.Checked == true)
                        {
                            String thongbao = "\n\rBạn có ghi nhớ.";
                        }
                        MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                        this.txtTenTK.Clear();
                        this.txtMK.Clear(); this.txtTenTK.Focus();
                    }
                }
                this.Close();
        }
    }
}
