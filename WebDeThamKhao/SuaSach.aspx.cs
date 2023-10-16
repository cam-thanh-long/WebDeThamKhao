using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDeThamKhao
{
    public partial class SuaSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["MaSach"] != null)
                {
                    int maSach;
                    if (int.TryParse(Request.QueryString["MaSach"], out maSach))
                    {
                        // Kết nối đến cơ sở dữ liệu
                        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CamThanhLong"].ConnectionString;
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT * FROM Sach WHERE MaSach = @MaSach";

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@MaSach", maSach);
                                SqlDataReader reader = cmd.ExecuteReader();

                                if (reader.Read())
                                {
                                    txtMaSach.Text = reader["MaSach"].ToString();
                                    txtTenSach.Text = reader["TenSach"].ToString();
                                    txtTheLoai.Text = reader["TheLoai"].ToString();
                                    txtSoLuong.Text = reader["SoLuong"].ToString();
                                    txtNamXB.Text = reader["NamXB"].ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        // Xử lý lỗi nếu tham số MaSach không hợp lệ
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int maSach;
            if (int.TryParse(txtMaSach.Text, out maSach))
            {
                string tenSach = txtTenSach.Text;
                string theLoai = txtTheLoai.Text;
                int soLuong;
                if (int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    int namXB;
                    if (int.TryParse(txtNamXB.Text, out namXB))
                    {
                        // Kết nối đến cơ sở dữ liệu và thực hiện cập nhật dữ liệu
                        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CamThanhLong"].ConnectionString;
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "UPDATE Sach SET TenSach = @TenSach, TheLoai = @TheLoai, SoLuong = @SoLuong, NamXB = @NamXB WHERE MaSach = @MaSach";

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@MaSach", maSach);
                                cmd.Parameters.AddWithValue("@TenSach", tenSach);
                                cmd.Parameters.AddWithValue("@TheLoai", theLoai);
                                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                                cmd.Parameters.AddWithValue("@NamXB", namXB);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Sau khi cập nhật xong, chuyển hướng về trang ThongtinSach.aspx
                        Response.Redirect("ThongtinSach.aspx");
                    }
                    else
                    {
                        // Xử lý lỗi nếu số lượng không hợp lệ
                    }
                }
                else
                {
                    // Xử lý lỗi nếu năm xuất bản không hợp lệ
                }
            }
            else
            {
                // Xử lý lỗi nếu Mã sách không hợp lệ
            }
        }
    }
}