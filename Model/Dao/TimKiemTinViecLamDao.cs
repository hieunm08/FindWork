using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class TimKiemTinViecLamDao
    {
        TimKiemViecLamDbConText db = null;

        public TimKiemTinViecLamDao()
        {
            db = new TimKiemViecLamDbConText();
        }


 /*       public IQueryable<TinViecLam> timKiemTinViecLam(SearchHomeModel searchModel)
        {
            var result = db.TinViecLams.AsQueryable();
            IEnumerable<CongTy> congTies = db.CongTies.Where(t => t.ID_ThanhPho == searchModel.ID_ThanhPho).AsEnumerable();

            TinViecLam tinViecLam = db.TinViecLams.Where

            if (searchModel != null)
            {

                if (searchModel.ID_NganhNghe.HasValue)
                    result = result.Where(x => x.ID_NganhNghe == searchModel.ID_NganhNghe && x.ID_CongTy = (congTies.));



                result = result.Where(x => x.ID_CongTy);






            }
            return result;
                }
*/
        public SearchHomeModel listHome()
        {
            CongTyDAO congTyDAO = new CongTyDAO();
            NganhNgheDAO ngheDAO = new NganhNgheDAO(); 
            ThanhPhoDAO thanhPhoDAO= new ThanhPhoDAO();
            TinViecLamDAO tinViecLamDAO = new TinViecLamDAO();
            var CongTyList = congTyDAO.dsCongTy();
            var NganhNGheList =  ngheDAO.dsNganhNghe();
            var thanhPhoList = thanhPhoDAO.dsThanhPho(); 
            var tinviecLamList = tinViecLamDAO.dsTinViecLam();

            var cV_UngViens = db.CV_UngVien.ToList();
            var UngViens = db.UngViens.ToList();
 
            
            var model = new SearchHomeModel()
            {
                CvUngviens = cV_UngViens,
                Ungviens = UngViens,
                ThanhPhos = thanhPhoList,
                NganhNghes = NganhNGheList,
                CongTys = CongTyList,
                TinViecLams = tinviecLamList
            };
            return model;
        }
    }
}
