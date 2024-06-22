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

namespace LTQL_NguyenDucThuan
{
    public partial class frm_HH : Form
    {
        int index = -1;
        public frm_HH()
        {
            InitializeComponent();
        }
        private SqlConnection connectDB()
        {
            String strCon = "Server=DESKTOP-E43PI42\\MSSQLSERVER2017;Database=QLHanghoa;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(strCon);
            return con;
        }

        private void LoadHangHoa()
        {
            try
            {
                using (SqlConnection con = connectDB())
                {
                    con.Open();
                    string query = "SELECT Mahang, tenhang,loaihang,donvitinh,soluong,dongia FROM DSHangHoa";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgvHH.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = connectDB())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO DSHangHoa 
                                    (Mahang, tenhang,loaihang,donvitinh,soluong,dongia) 
                            VALUES (@Mahang, @tenhang,@loaihang,@donvitinh,@soluong,@dongia)", con))
                    {
                        cmd.Parameters.AddWithValue("@Mahang", txtMahang.Text.Trim());
                        cmd.Parameters.AddWithValue("@tenhang", txtTenhang.Text.Trim());
                        cmd.Parameters.AddWithValue("@loaihang", cbxLoaihang.Text);
                        cmd.Parameters.AddWithValue("@donvitinh", cbxLoaihang.Text);
                        cmd.Parameters.AddWithValue("@soluong", int.Parse(txtSoluong.Text.Trim()));
                        cmd.Parameters.AddWithValue("@dongia", float.Parse(txtDongia.Text.Trim()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Them moi thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHangHoa();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tao moi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = connectDB())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE DSHangHoa 
                                                 SET tenhang = @tenhang, 
                                                     loaihang = @loaihang, 
                                                     donvitinh = @donvitinh,
                                                     soluong = @soluong,
                                                    dongia = @dongia
                                                 WHERE Mahang = @Mahang", con))
                    {
                        cmd.Parameters.AddWithValue("@Mahang", txtMahang.Text.Trim());
                        cmd.Parameters.AddWithValue("@tenhang", txtTenhang.Text.Trim());
                        cmd.Parameters.AddWithValue("@loaihang", cbxLoaihang.Text);
                        cmd.Parameters.AddWithValue("@donvitinh", cbxDonvitinh.Text);
                        cmd.Parameters.AddWithValue("@soluong", int.Parse(txtSoluong.Text.Trim()));
                        cmd.Parameters.AddWithValue("@dongia", float.Parse(txtDongia.Text.Trim()));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cap nhat thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadHangHoa();
                        }
                        else
                        {
                            MessageBox.Show("Khong co hang hoa nao duoc cap nhat", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi cap nhat " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string maHang = txtMahang.Text.Trim();
            if (!string.IsNullOrEmpty(maHang))
            {
                if (MessageBox.Show("Xac nhan xoa hang?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = connectDB())
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM DSHangHoa WHERE Mahang = @Mahang", con))
                            {
                                cmd.Parameters.AddWithValue("@Mahang", txtMahang.Text.Trim());
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xoa hang hoa thanh con.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadHangHoa();
                                }
                                else
                                {
                                    MessageBox.Show("Khong tim thay ma hang.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Loi xoa hang: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhap ma hang de xoa.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_HH_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
            cbxDonvitinh.DataSource = Const.listDVT;
            cbxLoaihang.DataSource = Const.listLH;

        }

        private void dtgvHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            if (index < 0 || index >= dtgvHH.Rows.Count)
                return;
            DataGridViewRow row = dtgvHH.Rows[index];
            txtMahang.Text = row.Cells[0].Value.ToString();
            txtTenhang.Text = row.Cells[1].Value.ToString();
            cbxLoaihang.Text = row.Cells[2].Value.ToString();
            cbxDonvitinh.Text = row.Cells[3].Value.ToString();
            txtSoluong.Text = row.Cells[4].Value.ToString();
            txtDongia.Text = row.Cells[5].Value.ToString();

        }
    }
}
