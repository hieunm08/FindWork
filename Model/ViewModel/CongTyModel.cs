namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class CongTyModel
    {
        public int ID_CongTy { get; set; }
        public string TenCongTy { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public string QuyMo { get; set; }
        public string SDT { get; set; }
        public string Website { get; set; }
        public string MoTa { get; set; }
        public string NguoiDaiDien { get; set; }
        public string Email { get; set; }
        public int ID_ThanhPho { get; set; }
        public  ThanhPho ThanhPho { get; set; }
        public  List<TinViecLam> TinViecLams { get; set; }
    }
}