using Microsoft.Data.SqlClient;

namespace QuanLyHocSinh
{
    static class KetNoi
    {
        public const string Chuoi =
            "Server=.;Database=DBHocSinh;Integrated Security=True;TrustServerCertificate=True;";

        // Chạy lệnh INSERT / UPDATE / DELETE: mở kết nối, thực thi, đóng kết nối
        public static int ChayLenh(string sql, params SqlParameter[] thamSo)
        {
            using (SqlConnection con = new SqlConnection(Chuoi))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddRange(thamSo);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Đổi lỗi SQL thành câu dễ hiểu
        public static string ThongBaoLoi(Exception ex)
        {
            if (ex is SqlException s)
            {
                if (s.Number == 2627 || s.Number == 2601)
                    return "Mã này đã tồn tại.";
                if (s.Number == 547)
                    return "Không thực hiện được: dữ liệu đang được bảng khác sử dụng hoặc mã lớp không tồn tại.";
            }
            return ex.Message;
        }
    }
}