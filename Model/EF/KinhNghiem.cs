namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KinhNghiem")]
    public partial class KinhNghiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KinhNghiem()
        {
            CV_UngVien = new HashSet<CV_UngVien>();
            TinViecLams = new HashSet<TinViecLam>();
        }

        [Key]
        public int ID_KinhNghiem { get; set; }

        [StringLength(255)]
        public string TenKinhNghiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_UngVien> CV_UngVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TinViecLam> TinViecLams { get; set; }
    }
}
