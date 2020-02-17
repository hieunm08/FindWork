using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class DangKyDAO
    {


        TimKiemViecLamDbConText db = null;

        public DangKyDAO()
        {
            db = new TimKiemViecLamDbConText();
        }

        public bool LuuCongTy(DangKy DangKy)
        {
            db.DangKies.Add(DangKy);
            db.SaveChanges();
            return true;
        }
        public bool XoaDangKy(int iddangky)
        {
            try
            {
                var kq = db.DangKies.Find(iddangky);
                db.DangKies.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool CapNhatDK(DangKy DangKy)
        {
            try
            {
                var kq = db.DangKies.Find(DangKy.ID_DangKy);
                kq.NgayXem = kq.NgayXem;
                kq.TrangThai = kq.TrangThai;
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
