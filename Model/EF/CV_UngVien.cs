namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CV_UngVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CV_UngVien()
        {
            DangKies = new HashSet<DangKy>();
        }

        [Key]
        public int ID_CV { get; set; }

        public int? ID_UngVien { get; set; }

        [StringLength(255)]
        public string TieuDe { get; set; }

        public int? ID_NganhNghe { get; set; }

        public string KyNang { get; set; }

        public int? ID_ViTri { get; set; }

        public int? ID_TrinhDo { get; set; }

        public int? ID_KinhNghiem { get; set; }

        [StringLength(255)]
        public string NgoaiNgu { get; set; }

        [StringLength(100)]
        public string MucLuong { get; set; }

        [StringLength(200)]
        public string BangCap { get; set; }

        public bool? TrangThai { get; set; }

        public virtual KinhNghiem KinhNghiem { get; set; }

        public virtual NganhNghe NganhNghe { get; set; }

        public virtual TrinhDo TrinhDo { get; set; }

        public virtual UngVien UngVien { get; set; }

        public virtual ViTriUngTuyen ViTriUngTuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKy> DangKies { get; set; }
    }
}
