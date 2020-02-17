using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class LoaiTaiKhoanDAO
    {

        TimKiemViecLamDbConText db = null;

        public LoaiTaiKhoanDAO()
        {
            db = new TimKiemViecLamDbConText();
        }

        public List<LoaiTaiKhoan> dsLoaiTK()
        {
            return db.LoaiTaiKhoans.ToList();
        }
        public bool LuuLoaiTK(LoaiTaiKhoan LoaiTaiKhoan)
        {
            db.LoaiTaiKhoans.Add(LoaiTaiKhoan);
            db.SaveChanges();
           return true;
        }
    }
}
