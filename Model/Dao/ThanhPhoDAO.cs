using Model.EF;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable LayDsThanhPho()
        {
            string constr = ConfigurationManager.ConnectionStrings["TimKiemViecLam"].ToString();
            SqlConnection _con = new SqlConnection(constr);
            SqlDataAdapter _da = new SqlDataAdapter("Select * From ThanhPho", constr);
            DataTable _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;

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
