using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CV_UngVienDAO
    {
        TimKiemViecLamDbConText db = null;

        public CV_UngVienDAO()
        {
            db = new TimKiemViecLamDbConText();
        }
        public List<CV_UngVien> dsViTriUngTuyen() => db.CV_UngVien.ToList();

        public bool LuuCV_UngVien(CV_UngVien CV_UngVien)
        {
            db.CV_UngVien.Add(CV_UngVien);
            db.SaveChanges();
            return true;
        }



        public bool XoaCV_UngVien(int ID_CV_UngVien)
        {
            try
            {
                var CV_UngVien1 = db.CV_UngVien.Find(ID_CV_UngVien);
                db.CV_UngVien.Remove(CV_UngVien1);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool SuaCV_UngVien(CV_UngVien CV_UngVien)
        {
            try
            {
                var kq = db.CV_UngVien.Find(CV_UngVien.ID_CV);
                kq.TieuDe = CV_UngVien.TieuDe;
                kq.ID_NganhNghe = CV_UngVien.ID_NganhNghe;
                kq.KyNang = CV_UngVien.KyNang;
                kq.ID_ViTri = CV_UngVien.ID_ViTri;
                kq.ID_TrinhDo = CV_UngVien.ID_TrinhDo;
                kq.ID_KinhNghiem = CV_UngVien.ID_KinhNghiem;
                kq.NgoaiNgu = CV_UngVien.NgoaiNgu;
                kq.MucLuong = CV_UngVien.MucLuong;
                kq.BangCap = CV_UngVien.BangCap;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int LayID_CV(int idungvien)
        {
            var kq = (CV_UngVien) from a in db.CV_UngVien
                     where (a.ID_UngVien == idungvien)
                     select new { a.ID_CV };
            int id_cv = kq.ID_CV;
            return id_cv;
        }
    }
}
