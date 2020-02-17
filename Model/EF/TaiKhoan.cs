namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        public int ID_TaiKhoan { get; set; }

        public int? ID_LoaiTaiKhoan { get; set; }

        [StringLength(150)]
        public string TenDangNhap { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(250)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        public int? ID_Vung { get; set; }

        public virtual LoaiTaiKhoan LoaiTaiKhoan { get; set; }

        public virtual VungMien VungMien { get; set; }
    }
}
