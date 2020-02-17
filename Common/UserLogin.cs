using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimKiemViecLam.Common
{
    public class UserLogin
    {
       public int ID_TaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string HoTen { get; set; }
        public int? ID_LoaiTaiKhoan { get; set; }
        public int? IsUngVien { get; set; }
        public int? IsTuyenDung { get; set; }

    }
}