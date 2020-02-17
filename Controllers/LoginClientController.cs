using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimKiemViecLam.Areas.Admin.Models;
using TimKiemViecLam.Common;

namespace TimKiemViecLam.Controllers
{
    public class LoginClientController : Controller
    {
        // GET: LoginClient
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            {
                if (ModelState.IsValid)
                {
                    var dao = new TaiKhoanDAO();
                    var result = dao.Login(model.UserName, model.PassWord);
                    if (result != null)
                    {


                        var user_Sesion = new UserLogin();

                        if (result is UngVien)
                        {
                            UngVien ungVien = (UngVien)result;
                            user_Sesion.TenDangNhap = ungVien.TenDangNhap;
                            user_Sesion.HoTen = ungVien.HoTen;
                            user_Sesion.IsUngVien = ungVien.IsUngVien;
                            Session.Add("User_Session1", user_Sesion);

                             return Redirect("/Admin/Home/Index");

                        }
                        if (result is CongTy)
                        {
                            CongTy congTy = (CongTy)result;
                            user_Sesion.TenDangNhap = congTy.TenDangNhap;
                            user_Sesion.HoTen = congTy.TenCongTy;
                            user_Sesion.IsTuyenDung = congTy.IsTuyenDung;
                            Session.Add("User_Session1", user_Sesion);
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Tài khoản hoặc  mật khẩu  không đúng !");
                    }
                }
                return View("index");

            }
        }
    }
}