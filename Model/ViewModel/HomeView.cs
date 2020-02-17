using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class HomeView
    {
        public List<UngVien> UngViens { get;  set; }
        public List<TinViecLam> TinViecLams { get;  set; }
        public List<CongTy> CongTies { get;  set; }
        public List<CV_UngVien> CV_UngVien { get;  set; }

        public CongTy CongTy { get; set; }
        public NganhNghe NganhNghe { get; set; }

        public KinhNghiem KinhNghiem { get; set; }

        public ViTriUngTuyen ViTriUngTuyen { get; set; }

        public  TrinhDo TrinhDo { get; set; }
        public ThanhPho ThanhPho { get; set; }
        public TinViecLam TinViecLam { get; set; }

    }
}
