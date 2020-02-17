namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class CV_UngVienModel
    {

       
        public int ID_CV { get; set; }
        public int ID_UngVien { get; set; }
        public string TieuDe { get; set; }
        public int ID_NganhNghe { get; set; }
        public string KyNang { get; set; }
        public int ID_ViTri { get; set; }
        public int ID_TrinhDo { get; set; }
        public int ID_KinhNghiem { get; set; }
        public string NgoaiNgu { get; set; }
        public string MucLuong { get; set; }
        public string BangCap { get; set; }
        public bool TrangThai { get; set; }
        public  KinhNghiem KinhNghiem { get; set; }
        public  NganhNghe NganhNghe { get; set; }
        public  TrinhDo TrinhDo { get; set; }
        public  UngVien UngVien { get; set; }
        public  ViTriUngTuyen ViTriUngTuyen { get; set; }
        public  List<DangKy> DangKies { get; set; }
    }
}
