using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimKiemViecLam.Areas.Admin.Controllers
{
    public class NganhNgheController : BaseController
    {
        // GET: Admin/NganhNghe
        public ActionResult Index()
        {
            var nganhNghe = new NganhNgheDAO();
            List<NganhNghe> nganhNghes = nganhNghe.dsNganhNghe();
            return View(nganhNghes);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            new NganhNgheDAO().XoaNganh(id);
            SetAlert("Xóa ngành nghề thành công", "success");
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Create(NganhNghe nganhNghe)
        {
            if (ModelState.IsValid)
            {
                var dao = new NganhNgheDAO();
                var check = dao.LuuNganh(nganhNghe);
                if (check == true)
                {
                    SetAlert("Thêm ngành nghề thành công", "success");
                    return RedirectToAction("index");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới không thành công");
                }
            }
            else
            {
                Response.Write("Không được để trống !");

            }

            return View("index");

        }
        [HttpPost]
        public ActionResult Edit(NganhNghe nganhNghe)
        {
            if (ModelState.IsValid)
            {
                var dao = new NganhNgheDAO();
                var check = dao.SuaNganhNghe(nganhNghe);
                if (check == true)
                {
                    SetAlert("Cập nhật ngành nghề thành công", "success");
                    return RedirectToAction("index");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật không thành công");
                }
            }
            return View("index");

        }
    }
}