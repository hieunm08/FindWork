namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinViecLam")]
    public partial class TinViecLam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinViecLam()
        {
            DangKies = new HashSet<DangKy>();
        }

        [Key]
        public int ID_ViecLam { get; set; }

        [StringLength(250)]
        public string TieuDeViecLam { get; set; }

        public string MoTa { get; set; }

        public int? ID_NganhNghe { get; set; }

        public int? ID_ViTri { get; set; }

        [StringLength(100)]
        public string GioiTinh { get; set; }

        public string YeuCauKyNang { get; set; }

        [StringLength(100)]
        public string ThoiGianThuViec { get; set; }

        public int? ID_KinhNghiem { get; set; }

        public int? ID_TrinhDo { get; set; }

        [StringLength(50)]
        public string MucLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        public bool? TrangThai { get; set; }

        public int? ID_CongTy { get; set; }

        public int? SoLuong { get; set; }

        public string YeuCauHoSo { get; set; }

        public virtual CongTy CongTy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKy> DangKies { get; set; }

        public virtual KinhNghiem KinhNghiem { get; set; }

        public virtual NganhNghe NganhNghe { get; set; }

        public virtual TrinhDo TrinhDo { get; set; }

        public virtual ViTriUngTuyen ViTriUngTuyen { get; set; }
    }
}
