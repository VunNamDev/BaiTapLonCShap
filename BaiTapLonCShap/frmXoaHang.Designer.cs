namespace BaiTapLonCShap
{
    partial class frmXoaHang
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
            this.txtSoLuongCo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonViTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboNCC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboLoai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnXoaHang = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtSoLuongCo
            // 
            // 
            // 
            // 
            this.txtSoLuongCo.Border.Class = "TextBoxBorder";
            this.txtSoLuongCo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuongCo.Location = new System.Drawing.Point(192, 164);
            this.txtSoLuongCo.Name = "txtSoLuongCo";
            this.txtSoLuongCo.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuongCo.TabIndex = 20;
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.Border.Class = "TextBoxBorder";
            this.txtDonGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGia.Location = new System.Drawing.Point(192, 102);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(121, 20);
            this.txtDonGia.TabIndex = 18;
            // 
            // txtDonViTinh
            // 
            // 
            // 
            // 
            this.txtDonViTinh.Border.Class = "TextBoxBorder";
            this.txtDonViTinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonViTinh.Location = new System.Drawing.Point(192, 76);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(121, 20);
            this.txtDonViTinh.TabIndex = 17;
            // 
            // txtTenHang
            // 
            // 
            // 
            // 
            this.txtTenHang.Border.Class = "TextBoxBorder";
            this.txtTenHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenHang.Location = new System.Drawing.Point(192, 50);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(121, 20);
            this.txtTenHang.TabIndex = 9;
            // 
            // txtMaHang
            // 
            // 
            // 
            // 
            this.txtMaHang.Border.Class = "TextBoxBorder";
            this.txtMaHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHang.Location = new System.Drawing.Point(192, 24);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(121, 20);
            this.txtMaHang.TabIndex = 8;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            // 
            // cboNCC
            // 
            this.cboNCC.DisplayMember = "Text";
            this.cboNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.ItemHeight = 14;
            this.cboNCC.Location = new System.Drawing.Point(192, 196);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(121, 20);
            this.cboNCC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboNCC.TabIndex = 21;
            // 
            // cboLoai
            // 
            this.cboLoai.DisplayMember = "Text";
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.ItemHeight = 14;
            this.cboLoai.Location = new System.Drawing.Point(192, 138);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 20);
            this.cboLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLoai.TabIndex = 19;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(22, 196);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(96, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "Nhà cung cấp";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(22, 167);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(96, 23);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "Số lượng có";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(22, 138);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(96, 23);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Loại";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(22, 109);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(96, 23);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "Đơn giá";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(22, 80);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(96, 23);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "Đơn vị tính";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(22, 51);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 23);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "Tên hàng";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "Mã hàng";
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaHang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaHang.Enabled = false;
            this.btnXoaHang.Location = new System.Drawing.Point(119, 265);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(121, 23);
            this.btnXoaHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaHang.TabIndex = 22;
            this.btnXoaHang.Text = "Xóa hàng";
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(261, 265);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(52, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmXoaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtSoLuongCo);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnXoaHang);
            this.Name = "frmXoaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXoaHang";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuongCo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonViTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNCC;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLoai;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnXoaHang;
        private DevComponents.DotNetBar.ButtonX btnHuy;
    }
}