using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class TinViecLamDAO
    {
        TimKiemViecLamDbConText db = null;

        public TinViecLamDAO()
        {
            db = new TimKiemViecLamDbConText();
        }

        public List<TinViecLam> dsTinViecLam()
        {
            return db.TinViecLams.ToList();
        }

        public bool LuuTinViecLam(TinViecLam tinViecLam)
        {
            db.TinViecLams.Add(tinViecLam);
            db.SaveChanges();
            return true;
        }


        public bool XoaViecLam(int id) { 
        
            try
            {
                var kq = db.TinViecLams.Find(id);
                db.TinViecLams.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool CapNhapViecLam(TinViecLam tinViecLam)
        {
            try
            {
                var kq = db.TinViecLams.Find(tinViecLam.ID_ViecLam);
                kq.TieuDeViecLam = tinViecLam.TieuDeViecLam;
                kq.MoTa = tinViecLam.MoTa;
                kq.ID_NganhNghe = tinViecLam.ID_NganhNghe;
                kq.ID_ViTri = tinViecLam.ID_ViTri;
                kq.GioiTinh = tinViecLam.GioiTinh;
                kq.YeuCauKyNang = tinViecLam.YeuCauKyNang;
                kq.ThoiGianThuViec = tinViecLam.ThoiGianThuViec;
                kq.ID_KinhNghiem = tinViecLam.ID_KinhNghiem;
                kq.ID_TrinhDo = tinViecLam.ID_TrinhDo;
                kq.MucLuong = tinViecLam.MucLuong;
                kq.NgayHetHan = tinViecLam.NgayHetHan;
                kq.TrangThai = tinViecLam.TrangThai;
                kq.SoLuong = tinViecLam.SoLuong;
                kq.YeuCauHoSo = tinViecLam.YeuCauHoSo;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
