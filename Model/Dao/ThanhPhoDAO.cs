using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ThanhPhoDAO
    {
        TimKiemViecLamDbConText db = null;

        public ThanhPhoDAO()
        {
            db = new TimKiemViecLamDbConText();
        }

        public List<ThanhPho> dsThanhPho()
        {
            return db.ThanhPhoes.ToList();
        }

        public bool LuuTP(ThanhPho thanhPho)
        {
            db.ThanhPhoes.Add(thanhPho);
            db.SaveChanges();
            return true;
        }


        public bool XoaThanhPho(int id)
        {
            try
            {
                var kq = db.ThanhPhoes.Find(id);
                db.ThanhPhoes.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool SuaThanhPho(ThanhPho thanhPho)
        {
            try
            {
                var kq = db.ThanhPhoes.Find(thanhPho.ID_ThanhPho);
                kq.TenThanhPho = thanhPho.TenThanhPho;
                kq.ID_Vung= thanhPho.ID_Vung;
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
