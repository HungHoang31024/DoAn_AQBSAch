namespace Quản_Lý_Bán_Sach
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.btnDN = new System.Windows.Forms.Button();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.radGN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDN.Location = new System.Drawing.Point(247, 313);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(183, 59);
            this.btnDN.TabIndex = 0;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.BackColor = System.Drawing.Color.Silver;
            this.lblTenTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenTK.Location = new System.Drawing.Point(63, 126);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(175, 33);
            this.lblTenTK.TabIndex = 1;
            this.lblTenTK.Text = "Tên tài khoản:";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.BackColor = System.Drawing.Color.Silver;
            this.lblMK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMK.Location = new System.Drawing.Point(63, 200);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(129, 33);
            this.lblMK.TabIndex = 1;
            this.lblMK.Text = "Mật khẩu:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(247, 124);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(308, 35);
            this.txtTenTK.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(247, 198);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(308, 35);
            this.txtMK.TabIndex = 2;
            // 
            // radGN
            // 
            this.radGN.AutoSize = true;
            this.radGN.BackColor = System.Drawing.Color.Silver;
            this.radGN.Location = new System.Drawing.Point(488, 271);
            this.radGN.Name = "radGN";
            this.radGN.Size = new System.Drawing.Size(115, 31);
            this.radGN.TabIndex = 3;
            this.radGN.TabStop = true;
            this.radGN.Text = "Ghi nhớ";
            this.radGN.UseVisualStyleBackColor = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 536);
            this.Controls.Add(this.radGN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTenTK);
            this.Controls.Add(this.btnDN);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DangNhap";
            this.Text = "Đăng_nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDN;
        private Label lblTenTK;
        private Label lblMK;
        private TextBox txtTenTK;
        private TextBox txtMK;
        private RadioButton radGN;
    }
}