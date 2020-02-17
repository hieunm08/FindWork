namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UngVien")]
    public partial class UngVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UngVien()
        {
            CV_UngVien = new HashSet<CV_UngVien>();
        }

        [Key]
        public int ID_UngVien { get; set; }

        [StringLength(150)]
        public string HoTen { get; set; }

        [StringLength(100)]
        public string MatKhau { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string GioiTinh { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        public int? ID_ThanhPho { get; set; }

        public int? IsUngVien { get; set; }

        [StringLength(255)]
        public string TenDangNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_UngVien> CV_UngVien { get; set; }

        public virtual ThanhPho ThanhPho { get; set; }
    }
}
