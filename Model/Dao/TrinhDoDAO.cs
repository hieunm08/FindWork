using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class TrinhDoDAO
    {

        TimKiemViecLamDbConText db = null;

        public TrinhDoDAO()
        {
            db = new TimKiemViecLamDbConText();
        }
        public List<TrinhDo> dsTrinhDo() => db.TrinhDoes.ToList();

        public bool LuuTrinhDo(TrinhDo trinhDo ) {
            db.TrinhDoes.Add(trinhDo);
            db.SaveChanges();
            return true;
        }



        public bool XoaTrinhDo(int ID_trinhDo)
        {
            try
            {
                var TrinhDoess = db.TrinhDoes.Find(ID_trinhDo);
                db.TrinhDoes.Remove(TrinhDoess);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool SuaTrinhDo(TrinhDo trinhDo)
        {
            try
            {
                var trinhDo1 = db.TrinhDoes.Find(trinhDo.ID_TrinhDo);
                trinhDo1.TenTrinhDo = trinhDo.TenTrinhDo;
                trinhDo1.TinViecLams = trinhDo.TinViecLams;
                trinhDo1.CV_UngVien = trinhDo.CV_UngVien;
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
