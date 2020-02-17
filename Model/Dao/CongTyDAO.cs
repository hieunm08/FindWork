using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CongTyDAO
    {
        TimKiemViecLamDbConText db = null;

        public CongTyDAO()
        {
            db = new TimKiemViecLamDbConText();
        }
        public List<CongTy> dsCongTy() => db.CongTies.ToList();

        public bool LuuCongTy(CongTy CongTy)
        {
            db.CongTies.Add(CongTy);
            db.SaveChanges();
            return true;
        }



        public bool XoaCongTy(int ID_CongTy)
        {
            try
            {
                var CongTi = db.CongTies.Find(ID_CongTy);
                db.CongTies.Remove(CongTi);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //kiem tra ten dang nhap
        public bool KiemTraTenDangNhapCT(string tendangnhap)
        {
            var kq = db.CongTies.ToList();
            foreach (var s in kq)
            {
                if (s.TenDangNhap == tendangnhap)
                    return false;
                else
                    return true;
            }
            return true;
        }

        public bool SuaCongTy(CongTy CongTy)
        {
            try
            {
                var cty = db.CongTies.Find(CongTy.ID_CongTy);
                cty.TenCongTy = CongTy.TenDangNhap;
                cty.TenDangNhap = CongTy.TenDangNhap;
                cty.MatKhau = CongTy.MatKhau;
                cty.DiaChi = CongTy.DiaChi;
                cty.SDT = CongTy.SDT;
                cty.Website = CongTy.Website;
                cty.MoTa = CongTy.MoTa;
                cty.NguoiDaiDien = CongTy.NguoiDaiDien;
                cty.Email = CongTy.Email;
                cty.ID_ThanhPho = CongTy.ID_ThanhPho;
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
