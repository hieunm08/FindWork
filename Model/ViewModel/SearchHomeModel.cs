using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.EF
{
    public class SearchHomeModel
    {

        public UngVien UngVien { get; set; }
        public CV_UngVien CvUngvien { get; set; }

        public List<UngVien> Ungviens { get; set; }
        public List<CV_UngVien> CvUngviens { get; set; }

    

        public CongTy CongTy { get; set; }

        public List<CongTy> CongTys { get; set; }

        public List<TinViecLam> TinViecLams { get; set; }
        public TinViecLam TinViecLam { get; set; }
         
        public List<DangKy> DangKies { get; set; }

        public List<KinhNghiem> KinhNghiem { get; set; }
        public KinhNghiem kinhNghiem { get; set; }

        public List<NganhNghe> NganhNghes { get; set; }

        public NganhNghe NganhNghe { get; set; }    

        public List<TrinhDo> TrinhDos { get; set; }

        public TrinhDo TrinhDo { get; set; }
        public List<ViTriUngTuyen> ViTriUngTuyens { get; set; }

        public ViTriUngTuyen ViTriUngTuyen { get; set; }
    
        public ThanhPho ThanhPho { get; set; }
        public List<ThanhPho> ThanhPhos { get; set; }

    }
}