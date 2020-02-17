using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimKiemViecLam.Areas.Admin.Controllers
{
    public class KinhNghiemController : BaseController 
    {
        // GET: Admin/KinhNghiem
        public ActionResult Index()
        {
            var kinhNghiem = new KinhNghiemDAO();
            List<KinhNghiem> kinhNghiems = kinhNghiem.GetAllList();
            return View(kinhNghiems);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            new KinhNghiemDAO().xoaKinhNghiem(id);
            SetAlert("Xóa kinh nghiệm thành công", "success");
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Create(KinhNghiem kinhNghiem)
        {
            if (ModelState.IsValid)
            {
                var dao = new KinhNghiemDAO();
                var check = dao.luuKinhNghiem(kinhNghiem);
                if (check == true)
                {
                    SetAlert("Thêm kinh nghiệm thành công", "success");
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
        public ActionResult Edit(KinhNghiem kinhNghiem)
        {
            if (ModelState.IsValid)
            {
                var dao = new KinhNghiemDAO();
                var check = dao.suaKinhNghiem(kinhNghiem);
                if (check == true)
                {
                    SetAlert("Cập nhật kinh nghiệm thành công", "success");
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