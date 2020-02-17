namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public class DangKyModel
    {
        public int ID_DangKy { get; set; }
        public int? ID_CV { get; set; }
        public int? ID_ViecLam { get; set; }
        public DateTime? NgayXem { get; set; }
        public DateTime? NgayUngTuyen { get; set; }
        public bool? TrangThai { get; set; }
        public  CV_UngVien CV_UngVien { get; set; }

        public  TinViecLam TinViecLam { get; set; }
    
}
}
