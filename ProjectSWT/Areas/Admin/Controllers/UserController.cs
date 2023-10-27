using ProjectSWT.Dao;
using ProjectSWT.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSWT.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(string searchString, int page = 1, int pagesize = 10)
        {
            var dao = new UserDao();
            var model = dao.GetAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;    
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();    
                user.CreateDate = DateTime.Now;
                user.CreateBy = "Dương Quí On";
                long id = dao.Insert(user);
                if (id < 0)
                {
                    return RedirectToAction("Index", "User");   
                }
                else
                {
                    ModelState.AddModelError("", "Thêm người dùng thành công");
                }
            }
            return View("Create");
        }

        [HttpGet]    
        public ActionResult Edit(int id)
        {
            var dao = new UserDao().ViewDetail(id);
            return View(dao);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                user.CreateDate = DateTime.Now;
                bool result = dao.Update(user); 
                if (result)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thành công!");
                }
            }
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            new UserDao().Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ChangeStatus (long id)
        {
            var result = new UserDao().ChangeStatus(id);
            return Json(new
            {
                status = result
            });
        }
    }
}