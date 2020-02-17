namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongTy")]
    public partial class CongTy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongTy()
        {
            TinViecLams = new HashSet<TinViecLam>();
        }

        [Key]
        public int ID_CongTy { get; set; }

        [StringLength(255)]
        public string TenCongTy { get; set; }

        [StringLength(150)]
        public string TenDangNhap { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(250)]
        public string QuyMo { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        public string MoTa { get; set; }

        [StringLength(150)]
        public string NguoiDaiDien { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public int? ID_ThanhPho { get; set; }

        public int? IsTuyenDung { get; set; }

        public virtual ThanhPho ThanhPho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TinViecLam> TinViecLams { get; set; }
    }
}
