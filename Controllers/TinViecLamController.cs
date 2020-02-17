using Model.EF;

using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimKiemViecLam.Areas.Admin.Controllers;

namespace TimKiemViecLam.Controllers
{
    public class TinViecLamController : BaseController
    {
     
            TimKiemViecLamDbConText db = null;

            public TinViecLamController()
            {
                db = new TimKiemViecLamDbConText();
            }
            // GET: TinViecLam
            public ActionResult Index()
        {
            var dao = new HomeDAO();
            var model = dao.ListAs();
            ViewBag.NganhNghe = new SelectList(db.NganhNghes, "ID_NganhNghe", "TenNganhNghe");
            ViewBag.ThanhPho = new SelectList(db.ThanhPhoes, "ID_ThanhPho", "TenThanhPho");

            var timKiemTinViecLamDao = new TimKiemTinViecLamDao();
            SearchHomeModel searchHomeModel = timKiemTinViecLamDao.listHome();

            return View(searchHomeModel);
        }

        public ActionResult DetailIndex(int? id)
        {
            var dao = new HomeDAO();

            var model = dao.ListDetail(id);
            if (id != null) {
                return View(model);
            }
            if (model == null)
            {
                return RedirectToAction("Index", "TinViecLam");
            }
              return RedirectToAction("Index", "TinViecLam");
        }
    }
}