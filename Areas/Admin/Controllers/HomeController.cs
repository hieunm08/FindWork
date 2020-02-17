using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimKiemViecLam.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            var dao = new HomeDAO();
            var model = dao.ListAs();
            return View(model);
        }
       public ActionResult HomeMember()
        {
            return View();
        }
    }
}