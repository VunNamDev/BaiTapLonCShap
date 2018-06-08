namespace BaiTapLonCShap
{
    partial class frmXoaLichSuGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaLichSuGia));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.dtNgayKetThuc = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtNgayBatDau = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboMaHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtNgayKetThuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNgayCapNhat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNgayBatDau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnHuy);
            this.panelEx1.Controls.Add(this.dtNgayKetThuc);
            this.panelEx1.Controls.Add(this.dtNgayBatDau);
            this.panelEx1.Controls.Add(this.cboMaHang);
            this.panelEx1.Controls.Add(this.txtNgayKetThuc);
            this.panelEx1.Controls.Add(this.txtNgayCapNhat);
            this.panelEx1.Controls.Add(this.txtNgayBatDau);
            this.panelEx1.Controls.Add(this.txtDonGia);
            this.panelEx1.Controls.Add(this.label5);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.btnXoa);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(434, 331);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHuy.Location = new System.Drawing.Point(338, 264);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(38, 38);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 10;
            this.btnHuy.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dtNgayKetThuc
            // 
            // 
            // 
            // 
            this.dtNgayKetThuc.BackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor;
            this.dtNgayKetThuc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayKetThuc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayKetThuc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayKetThuc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayKetThuc.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayKetThuc.BackgroundStyle.CornerDiameter = 10;
            this.dtNgayKetThuc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayKetThuc.BackgroundStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgayKetThuc.ButtonDropDown.Visible = true;
            this.dtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKetThuc.Enabled = false;
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtNgayKetThuc.IsPopupCalendarOpen = false;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(358, 127);
            // 
            // 
            // 
            this.dtNgayKetThuc.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayKetThuc.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayKetThuc.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtNgayKetThuc.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayKetThuc.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayKetThuc.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayKetThuc.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayKetThuc.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayKetThuc.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayKetThuc.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayKetThuc.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayKetThuc.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.dtNgayKetThuc.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayKetThuc.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayKetThuc.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayKetThuc.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayKetThuc.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayKetThuc.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayKetThuc.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayKetThuc.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(18, 27);
            this.dtNgayKetThuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtNgayKetThuc.TabIndex = 2;
            this.dtNgayKetThuc.TabStop = false;
            this.dtNgayKetThuc.Value = new System.DateTime(2018, 5, 22, 14, 13, 29, 0);
            // 
            // dtNgayBatDau
            // 
            // 
            // 
            // 
            this.dtNgayBatDau.BackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor;
            this.dtNgayBatDau.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayBatDau.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayBatDau.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayBatDau.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayBatDau.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayBatDau.BackgroundStyle.CornerDiameter = 10;
            this.dtNgayBatDau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayBatDau.BackgroundStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgayBatDau.ButtonDropDown.Visible = true;
            this.dtNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtNgayBatDau.IsPopupCalendarOpen = false;
            this.dtNgayBatDau.Location = new System.Drawing.Point(358, 78);
            // 
            // 
            // 
            this.dtNgayBatDau.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayBatDau.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayBatDau.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtNgayBatDau.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayBatDau.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayBatDau.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayBatDau.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayBatDau.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayBatDau.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayBatDau.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayBatDau.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayBatDau.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.dtNgayBatDau.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayBatDau.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayBatDau.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayBatDau.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayBatDau.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayBatDau.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayBatDau.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayBatDau.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(18, 27);
            this.dtNgayBatDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtNgayBatDau.TabIndex = 1;
            this.dtNgayBatDau.TabStop = false;
            this.dtNgayBatDau.TextChanged += new System.EventHandler(this.dtNgayBatDau_TextChanged);
            // 
            // cboMaHang
            // 
            this.cboMaHang.DisplayMember = "Text";
            this.cboMaHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.ItemHeight = 25;
            this.cboMaHang.Location = new System.Drawing.Point(201, 38);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(175, 31);
            this.cboMaHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMaHang.TabIndex = 0;
            this.cboMaHang.SelectedIndexChanged += new System.EventHandler(this.cboMaHang_SelectedIndexChanged);
            // 
            // txtNgayKetThuc
            // 
            // 
            // 
            // 
            this.txtNgayKetThuc.Border.Class = "TextBoxBorder";
            this.txtNgayKetThuc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNgayKetThuc.Border.PaddingBottom = 3;
            this.txtNgayKetThuc.Border.PaddingTop = 10;
            this.txtNgayKetThuc.Enabled = false;
            this.txtNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayKetThuc.Location = new System.Drawing.Point(201, 123);
            this.txtNgayKetThuc.Multiline = true;
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(175, 34);
            this.txtNgayKetThuc.TabIndex = 9;
            // 
            // txtNgayCapNhat
            // 
            // 
            // 
            // 
            this.txtNgayCapNhat.Border.Class = "TextBoxBorder";
            this.txtNgayCapNhat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNgayCapNhat.Border.PaddingBottom = 3;
            this.txtNgayCapNhat.Border.PaddingTop = 10;
            this.txtNgayCapNhat.Enabled = false;
            this.txtNgayCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayCapNhat.Location = new System.Drawing.Point(201, 210);
            this.txtNgayCapNhat.Multiline = true;
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.Size = new System.Drawing.Size(175, 34);
            this.txtNgayCapNhat.TabIndex = 4;
            // 
            // txtNgayBatDau
            // 
            // 
            // 
            // 
            this.txtNgayBatDau.Border.Class = "TextBoxBorder";
            this.txtNgayBatDau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNgayBatDau.Border.PaddingBottom = 3;
            this.txtNgayBatDau.Border.PaddingTop = 10;
            this.txtNgayBatDau.Enabled = false;
            this.txtNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayBatDau.Location = new System.Drawing.Point(201, 75);
            this.txtNgayBatDau.Multiline = true;
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(175, 34);
            this.txtNgayBatDau.TabIndex = 9;
            this.txtNgayBatDau.TextChanged += new System.EventHandler(this.txtNgayBatDau_TextChanged);
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.Border.Class = "TextBoxBorder";
            this.txtDonGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGia.Border.PaddingBottom = 3;
            this.txtDonGia.Border.PaddingTop = 10;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(201, 167);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(175, 34);
            this.txtDonGia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(67, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày cập nhật";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(67, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(67, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày kết thúc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(67, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày bắt đầu ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(201, 264);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 38);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá lịch sử giá";
            this.btnXoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmXoaLichSuGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 331);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmXoaLichSuGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoá lịch sử giá";
            this.Load += new System.EventHandler(this.frmXoaLichSuGia_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayKetThuc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayBatDau;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMaHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNgayKetThuc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNgayCapNhat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNgayBatDau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnHuy;
    }
}