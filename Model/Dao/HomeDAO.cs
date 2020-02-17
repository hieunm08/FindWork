using Model.EF;
using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class HomeDAO
    {

        TimKiemViecLamDbConText db = null;

        public HomeDAO() {
            db = new TimKiemViecLamDbConText();
        }

        public HomeView ListAs()
        {
            var cV_UngViens = db.CV_UngVien.ToList();
            var UngViens = db.UngViens.ToList();
            var tinViecLam = db.TinViecLams.ToList();
            var congTies = db.CongTies.ToList();
            var model = new HomeView
            {
                CV_UngVien = cV_UngViens,
                UngViens = UngViens,
                TinViecLams = tinViecLam,
                CongTies = congTies
            };
            return model;

        }

        public HomeView ListDetail(int? id)
        {
            if ( db.TinViecLams.Find(id) == null)
            {
                return null;

            }
                TinViecLam tinViecLam = db.TinViecLams.Find(id);
                var congty = db.CongTies.Find(tinViecLam.ID_CongTy);
                var thanhPho = db.ThanhPhoes.Find(congty.ID_ThanhPho);
                var nganhNghe = db.NganhNghes.Find(tinViecLam.ID_NganhNghe);
                var trinhdo = db.TrinhDoes.Find(tinViecLam.ID_TrinhDo);
                var kinhnghiem = db.KinhNghiems.Find(tinViecLam.ID_KinhNghiem);
                var vitri = db.ViTriUngTuyens.Find(tinViecLam.ID_ViTri);

            CongTyDAO congTyDAO = new CongTyDAO();
            NganhNgheDAO ngheDAO = new NganhNgheDAO();
            ThanhPhoDAO thanhPhoDAO = new ThanhPhoDAO();
            TinViecLamDAO tinViecLamDAO = new TinViecLamDAO();
            var CongTyList = congTyDAO.dsCongTy();
            var tinviecLamList = tinViecLamDAO.dsTinViecLam();
            var model = new HomeView
                {
                    CongTy = congty,
                    ThanhPho = thanhPho,
                    NganhNghe = nganhNghe,
                    TrinhDo = trinhdo,
                    KinhNghiem = kinhnghiem,
                    ViTriUngTuyen = vitri,
                    TinViecLam = tinViecLam,
                    TinViecLams = tinviecLamList,
                    CongTies = CongTyList,

            };
                return model;   
        }
    }
    
}
