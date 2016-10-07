namespace VT.GPLX.VPDK.Presenation
{
    partial class frmRaSoatThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaSoatThongTin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xpPanel1 = new FPT.GPLX.Controls.XPPanel.XPPanel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new FPT.GPLX.Controls.DateTimePickerEx();
            this.dtpDenNgay = new FPT.GPLX.Controls.DateTimePickerEx();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new FPT.GPLX.Controls.DateTimePickerEx();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xpPanel2 = new FPT.GPLX.Controls.XPPanel.XPPanel();
            this.dgvDanhSachRaSoat = new FPT.GPLX.Controls.DataGridViewVista();
            this.xpPanel1.SuspendLayout();
            this.xpPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachRaSoat)).BeginInit();
            this.SuspendLayout();
            // 
            // xpPanel1
            // 
            this.xpPanel1.AllowCollapse = false;
            this.xpPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.xpPanel1.Caption = "Tìm kiếm";
            this.xpPanel1.Controls.Add(this.btnTimKiem);
            this.xpPanel1.Controls.Add(this.dtpNgaySinh);
            this.xpPanel1.Controls.Add(this.dtpDenNgay);
            this.xpPanel1.Controls.Add(this.txtSoCMND);
            this.xpPanel1.Controls.Add(this.label1);
            this.xpPanel1.Controls.Add(this.dtpTuNgay);
            this.xpPanel1.Controls.Add(this.txtHovaTen);
            this.xpPanel1.Controls.Add(this.label2);
            this.xpPanel1.Controls.Add(this.label5);
            this.xpPanel1.Controls.Add(this.label4);
            this.xpPanel1.Controls.Add(this.label3);
            this.xpPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpPanel1.Icon = global::VT.GPLX.VPDK.Properties.Resources.Search16x16;
            this.xpPanel1.Location = new System.Drawing.Point(0, 0);
            this.xpPanel1.Name = "xpPanel1";
            this.xpPanel1.ShowIcon = true;
            this.xpPanel1.ShowStatus = FPT.GPLX.Controls.XPPanel.XPPanel.PanelStatus.ShowPanel;
            this.xpPanel1.Size = new System.Drawing.Size(1153, 113);
            this.xpPanel1.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::VT.GPLX.VPDK.Properties.Resources.Search;
            this.btnTimKiem.Location = new System.Drawing.Point(785, 37);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(144, 43);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.DateTime = new System.DateTime(((long)(0)));
            this.dtpNgaySinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(391, 37);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(9);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(101, 23);
            this.dtpNgaySinh.TabIndex = 2;
            this.dtpNgaySinh.Value = new System.DateTime(((long)(0)));
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.DateTime = new System.DateTime(((long)(0)));
            this.dtpDenNgay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Location = new System.Drawing.Point(424, 72);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(9);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(101, 23);
            this.dtpDenNgay.TabIndex = 2;
            this.dtpDenNgay.Value = new System.DateTime(((long)(0)));
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(607, 37);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(141, 23);
            this.txtSoCMND.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày nhận hồ sơ từ";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.DateTime = new System.DateTime(((long)(0)));
            this.dtpTuNgay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Location = new System.Drawing.Point(197, 72);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(9);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(101, 23);
            this.dtpTuNgay.TabIndex = 2;
            this.dtpTuNgay.Value = new System.DateTime(((long)(0)));
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(134, 37);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(141, 23);
            this.txtHovaTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            // 
            // xpPanel2
            // 
            this.xpPanel2.AllowCollapse = true;
            this.xpPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.xpPanel2.Caption = "Danh sách tìm kiếm";
            this.xpPanel2.Controls.Add(this.dgvDanhSachRaSoat);
            this.xpPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpPanel2.Icon = ((System.Drawing.Image)(resources.GetObject("xpPanel2.Icon")));
            this.xpPanel2.Location = new System.Drawing.Point(0, 113);
            this.xpPanel2.Name = "xpPanel2";
            this.xpPanel2.ShowIcon = true;
            this.xpPanel2.ShowStatus = FPT.GPLX.Controls.XPPanel.XPPanel.PanelStatus.ShowPanel;
            this.xpPanel2.Size = new System.Drawing.Size(1153, 371);
            this.xpPanel2.TabIndex = 3;
            // 
            // dgvDanhSachRaSoat
            // 
            this.dgvDanhSachRaSoat.AllowUserToAddRows = false;
            this.dgvDanhSachRaSoat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(220)))));
            this.dgvDanhSachRaSoat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachRaSoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachRaSoat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachRaSoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachRaSoat.Location = new System.Drawing.Point(0, 24);
            this.dgvDanhSachRaSoat.Name = "dgvDanhSachRaSoat";
            this.dgvDanhSachRaSoat.ReadOnly = true;
            this.dgvDanhSachRaSoat.Size = new System.Drawing.Size(1153, 347);
            this.dgvDanhSachRaSoat.TabIndex = 1;
            // 
            // frmRaSoatThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 486);
            this.Controls.Add(this.xpPanel2);
            this.Controls.Add(this.xpPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRaSoatThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rà soát thông tin máy chủ";
            this.xpPanel1.ResumeLayout(false);
            this.xpPanel1.PerformLayout();
            this.xpPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachRaSoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FPT.GPLX.Controls.XPPanel.XPPanel xpPanel1;
        private System.Windows.Forms.Button btnTimKiem;
        private FPT.GPLX.Controls.DateTimePickerEx dtpNgaySinh;
        private FPT.GPLX.Controls.DateTimePickerEx dtpDenNgay;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Label label1;
        private FPT.GPLX.Controls.DateTimePickerEx dtpTuNgay;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FPT.GPLX.Controls.XPPanel.XPPanel xpPanel2;
        private FPT.GPLX.Controls.DataGridViewVista dgvDanhSachRaSoat;
    }
}