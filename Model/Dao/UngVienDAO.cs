using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class UngVienDAO
    {
        TimKiemViecLamDbConText db = null;

        public UngVienDAO()
        {
            db = new TimKiemViecLamDbConText();
        }

        public List<UngVien> dsUngVien()
        {
            return db.UngViens.ToList();
        }

        public bool LuuUngVien(UngVien UngVien)
        {
            db.UngViens.Add(UngVien);
            db.SaveChanges();
            return true;
        }


        public bool XoaUngVien(int id)
        {
            try
            {
                var kq = db.UngViens.Find(id);
                db.UngViens.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //kiem tra email
        public bool KiemTraEmail(string email)
        {
            var kq = from n in db.UngViens
                     select n;
            foreach (var s in kq)
            {
                if (s.Email == email)
                    return false;
                else
                    return true;
            }
            return true;
        }

    }
}
