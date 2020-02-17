using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class NganhNgheDAO
    {
        TimKiemViecLamDbConText db = null;

        public NganhNgheDAO()
        {
            db = new TimKiemViecLamDbConText();
        }

        public List<NganhNghe> dsNganhNghe() {
            return db.NganhNghes.ToList();
        }

        public bool LuuNganh(NganhNghe nganhNghe)
        {
            db.NganhNghes.Add(nganhNghe);
            db.SaveChanges();
            return true;
        }


        public bool XoaNganh(int id)
        {
            try
            {
                var kq = db.NganhNghes.Find(id);
                db.NganhNghes.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool SuaNganhNghe(NganhNghe nganhNghe)
        {
            try
            {
                var kq = db.NganhNghes.Find(nganhNghe.ID_NganhNghe);
                kq.TenNganhNghe = nganhNghe.TenNganhNghe;
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
    
