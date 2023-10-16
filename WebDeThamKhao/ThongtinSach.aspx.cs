using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDeThamKhao
{
    public partial class ThongtinSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Kết nối đến cơ sở dữ liệu
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CamThanhLong"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Truy vấn dữ liệu sách xuất bản năm 2021
                    string query = "SELECT Sach.MaSach, Sach.TenSach, Sach.TheLoai, Sach.SoLuong, Sach.NamXB, NHAXB.TenNXB, NHAXB.Email, NHAXB.DiaChi " +
                                   "FROM Sach " +
                                   "INNER JOIN NHAXB ON Sach.MaNXB = NHAXB.MaNXB " +
                                   "WHERE Sach.NamXB = 2021";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Gán dữ liệu vào GridView hoặc điều khiển khác trên trang
                        GridView1.DataSource = table;
                        GridView1.DataBind();
                    }
                }
            }
        }
    }
}