namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class TaiKhoanModel
    {

        public int ID_TaiKhoan { get; set; }

        public int? ID_LoaiTaiKhoan { get; set; }


        public string TenDangNhap { get; set; }


        public string MatKhau { get; set; }


        public string HoTen { get; set; }


        public string Email { get; set; }


        public string SDT { get; set; }

        public int? ID_Vung { get; set; }

        public LoaiTaiKhoan LoaiTaiKhoan { get; set; }

        public VungMien VungMien { get; set; }
    
    }
}
