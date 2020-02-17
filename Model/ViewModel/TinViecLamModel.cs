namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public  class TinViecLamModel
    {
       
        public int ID_ViecLam { get; set; }

        public string TieuDeViecLam { get; set; }

        public string MoTa { get; set; }

        public int? ID_NganhNghe { get; set; }

        public int? ID_ViTri { get; set; }

        public string GioiTinh { get; set; }

        public string YeuCauKyNang { get; set; }

  
        public string ThoiGianThuViec { get; set; }

        public int? ID_KinhNghiem { get; set; }

        public int? ID_TrinhDo { get; set; }


        public string MucLuong { get; set; }

        public DateTime? NgayDang { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public bool? TrangThai { get; set; }

        public int? ID_CongTy { get; set; }

        public int? SoLuong { get; set; }

        public string YeuCauHoSo { get; set; }

        public  CongTy CongTy { get; set; }

        public List<DangKy> DangKies { get; set; }

        public  KinhNghiem KinhNghiem { get; set; }

        public  NganhNghe NganhNghe { get; set; }

        public  TrinhDo TrinhDo { get; set; }

        public  ViTriUngTuyen ViTriUngTuyen { get; set; }
    }
}
