using Model.Dao;
using Model.EF;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace TimKiemViecLam.Controllers
{
    public class CongTyController : Controller
    {
        private CongTyDAO congTyDAO;
        private ThanhPhoDAO thanhPhoDAO;

        public CongTyController()
        {
            congTyDAO = new CongTyDAO();
            thanhPhoDAO = new ThanhPhoDAO();
        }

        // GET: CongTy
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddOrEdit()
        {
            DataTable _dt = thanhPhoDAO.LayDsThanhPho();
            ViewBag.cityList = ToSelectList(_dt, "ID_ThanhPho", "TenThanhPho");
            return View();
        }

        [HttpPost]
        public ActionResult AddOrEdit(CongTy congTy)
        {
            //var companydao = new congtydao();
            if (ModelState.IsValid)
            {
                bool result = congTyDAO.LuuCongTy(congTy);
                if (result)
                {
                    return Redirect(Request.UrlReferrer.ToString());
                }
                else
                {
                    ModelState.AddModelError("", "Create company failed!");
                }
            }
            return View(congTy);
        }

        [NonAction]
        public SelectList ToSelectList(DataTable table, string valueField, string textField)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (DataRow row in table.Rows)
            {
                list.Add(new SelectListItem()
                {
                    Text = row[textField].ToString(),
                    Value = row[valueField].ToString()
                });
            }

            return new SelectList(list, "Value", "Text");
        }
    }
}