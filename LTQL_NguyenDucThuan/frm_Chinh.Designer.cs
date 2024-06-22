namespace LTQL_NguyenDucThuan
{
    partial class frm_Chinh
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
            this.components = new System.ComponentModel.Container();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            this.mnQL = new System.Windows.Forms.MenuStrip();
            this.mnQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQLHT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQLHH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQLNS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQLPB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvQLHH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.mnQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLHH)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(187, -101);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // mnQL
            // 
            this.mnQL.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnQL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQLTK,
            this.mnQLHT,
            this.mnThongke,
            this.mnTrogiup});
            this.mnQL.Location = new System.Drawing.Point(0, 0);
            this.mnQL.Name = "mnQL";
            this.mnQL.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnQL.Size = new System.Drawing.Size(1078, 30);
            this.mnQL.TabIndex = 11;
            this.mnQL.Text = "MenuQLNS";
            // 
            // mnQLTK
            // 
            this.mnQLTK.Name = "mnQLTK";
            this.mnQLTK.Size = new System.Drawing.Size(138, 24);
            this.mnQLTK.Text = "Quản lý tài khoản";
            // 
            // mnQLHT
            // 
            this.mnQLHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQLHH,
            this.tsQLNS,
            this.tsQLPB});
            this.mnQLHT.Name = "mnQLHT";
            this.mnQLHT.Size = new System.Drawing.Size(136, 24);
            this.mnQLHT.Text = "Quản lý hệ thống";
            // 
            // tsQLHH
            // 
            this.tsQLHH.Name = "tsQLHH";
            this.tsQLHH.Size = new System.Drawing.Size(224, 26);
            this.tsQLHH.Text = "QL hàng hóa";
            this.tsQLHH.Click += new System.EventHandler(this.tsQLHH_Click);
            // 
            // tsQLNS
            // 
            this.tsQLNS.Name = "tsQLNS";
            this.tsQLNS.Size = new System.Drawing.Size(224, 26);
            this.tsQLNS.Text = "QL nhân sự";
            // 
            // tsQLPB
            // 
            this.tsQLPB.Name = "tsQLPB";
            this.tsQLPB.Size = new System.Drawing.Size(224, 26);
            this.tsQLPB.Text = "QL phòng ban";
            // 
            // mnThongke
            // 
            this.mnThongke.Name = "mnThongke";
            this.mnThongke.Size = new System.Drawing.Size(144, 24);
            this.mnThongke.Text = "Báo cáo/Thống kê";
            // 
            // mnTrogiup
            // 
            this.mnTrogiup.Name = "mnTrogiup";
            this.mnTrogiup.Size = new System.Drawing.Size(78, 24);
            this.mnTrogiup.Text = "Trợ giúp";
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(-173, -101);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(67, -101);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(-53, -101);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(129, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ HÀNG HÓA";
            // 
            // dtgvQLHH
            // 
            this.dtgvQLHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLHH.Location = new System.Drawing.Point(12, 181);
            this.dtgvQLHH.Name = "dtgvQLHH";
            this.dtgvQLHH.RowHeadersWidth = 51;
            this.dtgvQLHH.RowTemplate.Height = 24;
            this.dtgvQLHH.Size = new System.Drawing.Size(1054, 446);
            this.dtgvQLHH.TabIndex = 20;
            // 
            // frm_Chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 639);
            this.Controls.Add(this.dtgvQLHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.mnQL);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "frm_Chinh";
            this.Text = "frm_Chinh";
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.mnQL.ResumeLayout(false);
            this.mnQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.MenuStrip mnQL;
        private System.Windows.Forms.ToolStripMenuItem mnQLTK;
        private System.Windows.Forms.ToolStripMenuItem mnQLHT;
        private System.Windows.Forms.ToolStripMenuItem tsQLHH;
        private System.Windows.Forms.ToolStripMenuItem tsQLNS;
        private System.Windows.Forms.ToolStripMenuItem mnThongke;
        private System.Windows.Forms.ToolStripMenuItem mnTrogiup;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ToolStripMenuItem tsQLPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvQLHH;
    }
}