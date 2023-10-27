using ProjectSWT.Areas.Admin.Models;
using ProjectSWT.Common;
using ProjectSWT.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSWT.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.username, model.password);
                if (result == 1)
                {
                    var user = dao.GetByID(model.username);
                    var userSession = new UserLogin();
                    userSession.Username = user.Username;
                    userSession.UserId = user.ID;
                    Session.Add(CommonContants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại!");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đã bị khóa!");
                }
                else
                {
                    ModelState.AddModelError("", "Bạn không có quyền truy cập!");
                }
            }
            return View("Index");
        }
    }
}