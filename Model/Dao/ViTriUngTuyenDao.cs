using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ViTriUngTuyenDao
    {

        TimKiemViecLamDbConText db = null;

        public ViTriUngTuyenDao()
        {
            db = new TimKiemViecLamDbConText();
        }
        public List<ViTriUngTuyen> dsViTriUngTuyen() => db.ViTriUngTuyens.ToList();

        public bool LuuViTriUngTuyen(ViTriUngTuyen viTriUngTuyen)
        {
            db.ViTriUngTuyens.Add(viTriUngTuyen);
            db.SaveChanges();
            return true;
        }



        public bool XoaViTriUngTuyen(int ID_ViTriUngTuyen)
        {
            try
            {
                var ViTriUngTuyens1 = db.ViTriUngTuyens.Find(ID_ViTriUngTuyen);
                db.ViTriUngTuyens.Remove(ViTriUngTuyens1);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool SuaViTriUngTuyen(ViTriUngTuyen ViTriUngTuyen)
        {
            try
            {
                var ViTriUngTuyen1 = db.ViTriUngTuyens.Find(ViTriUngTuyen.ID_ViTri);
                ViTriUngTuyen1.TenViTri = ViTriUngTuyen.TenViTri;
                ViTriUngTuyen1.TinViecLams = ViTriUngTuyen.TinViecLams;
                ViTriUngTuyen1.CV_UngVien = ViTriUngTuyen.CV_UngVien;
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
