using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class VungMienDAO
    {
        TimKiemViecLamDbConText db = null;

        public VungMienDAO()
        {
            db = new TimKiemViecLamDbConText();
        }

        public List<VungMien> dsVung()
        {
            return db.VungMiens.ToList();
        }

        public bool LuuVung(VungMien vungMien)
        {
            db.VungMiens.Add(vungMien);
            db.SaveChanges();
            return true;
        }


        public bool XoaVung(int id)
        {
            try
            {
                var kq = db.VungMiens.Find(id);
                db.VungMiens.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaVung(VungMien vungMien)
        {
            try
            {
                var kq = db.VungMiens.Find(vungMien.ID_Vung);
                kq.TenVung = vungMien.TenVung;
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
