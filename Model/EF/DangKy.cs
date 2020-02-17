namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKy")]
    public partial class DangKy
    {
        [Key]
        public int ID_DangKy { get; set; }

        public int? ID_CV { get; set; }

        public int? ID_ViecLam { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayXem { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayUngTuyen { get; set; }

        public bool? TrangThai { get; set; }

        public virtual CV_UngVien CV_UngVien { get; set; }

        public virtual TinViecLam TinViecLam { get; set; }
    }
}
