using Model.EF;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
   public class KinhNghiemDAO
    {

        TimKiemViecLamDbConText db =null;

        public KinhNghiemDAO()
        {
            db = new TimKiemViecLamDbConText();
        }

        //get all KinhNghiem
        public List<KinhNghiem> GetAllList() => db.KinhNghiems.ToList();

        public bool luuKinhNghiem(KinhNghiem km)
        {
            db.KinhNghiems.Add(km);
            db.SaveChanges();
            return true;
        }

        public IEnumerable<KinhNghiem> ListAll1(string searching, int page, int pageSize)
        {
            IQueryable<KinhNghiem> model = db.KinhNghiems;
            if (!string.IsNullOrEmpty(searching))
            {
                model = model.Where(x => x.TenKinhNghiem.Contains(searching)).OrderBy(x => x.ID_KinhNghiem);
            }
            return model.OrderBy(x => x.ID_KinhNghiem).ToPagedList(page, pageSize);
        }

        public bool xoaKinhNghiem(int ID_KinhNghiem)
        {
            try
            {
                var kinhNghiem = db.KinhNghiems.Find(ID_KinhNghiem);
                db.KinhNghiems.Remove(kinhNghiem);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool suaKinhNghiem(KinhNghiem km)
        {
            try
            {
                var kinhNghiem = db.KinhNghiems.Find(km.ID_KinhNghiem);
                kinhNghiem.TenKinhNghiem = km.TenKinhNghiem;
                kinhNghiem.TinViecLams = km.TinViecLams;
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
