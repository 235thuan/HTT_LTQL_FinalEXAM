namespace LTQL_NguyenDucThuan
{
    partial class frm_HH
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLoaihang = new System.Windows.Forms.ComboBox();
            this.cbxDonvitinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dtgvHH = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(142, 81);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(237, 22);
            this.txtMahang.TabIndex = 1;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(142, 130);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(237, 22);
            this.txtTenhang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại hàng";
            // 
            // cbxLoaihang
            // 
            this.cbxLoaihang.FormattingEnabled = true;
            this.cbxLoaihang.Location = new System.Drawing.Point(142, 191);
            this.cbxLoaihang.Name = "cbxLoaihang";
            this.cbxLoaihang.Size = new System.Drawing.Size(237, 24);
            this.cbxLoaihang.TabIndex = 5;
            // 
            // cbxDonvitinh
            // 
            this.cbxDonvitinh.FormattingEnabled = true;
            this.cbxDonvitinh.Location = new System.Drawing.Point(668, 84);
            this.cbxDonvitinh.Name = "cbxDonvitinh";
            this.cbxDonvitinh.Size = new System.Drawing.Size(237, 24);
            this.cbxDonvitinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn vị tính";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(668, 191);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(237, 22);
            this.txtDongia.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(668, 136);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(237, 22);
            this.txtSoluong.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(360, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(686, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(524, 267);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dtgvHH
            // 
            this.dtgvHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHH.Location = new System.Drawing.Point(68, 348);
            this.dtgvHH.Name = "dtgvHH";
            this.dtgvHH.RowHeadersWidth = 51;
            this.dtgvHH.RowTemplate.Height = 24;
            this.dtgvHH.Size = new System.Drawing.Size(837, 208);
            this.dtgvHH.TabIndex = 16;
            this.dtgvHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHH_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(245, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(436, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "QUẢN LÝ HÀNG HÓA";
            // 
            // frm_HH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 568);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgvHH);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDonvitinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxLoaihang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.label1);
            this.Name = "frm_HH";
            this.Text = "HangHoa";
            this.Load += new System.EventHandler(this.frm_HH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLoaihang;
        private System.Windows.Forms.ComboBox cbxDonvitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dtgvHH;
        private System.Windows.Forms.Label label7;
    }
}