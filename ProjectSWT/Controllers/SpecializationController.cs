using ProjectSWT.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSWT.Controllers
{
    public class SpecializationController : Controller
    {
        // GET: Specialization
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Category(long id)
        {
            var cate = new CateSpecializationDao().ViewDetail(id);
            ViewBag.Cate = cate;
            var model = new SpecializationDao().ListByCateSpecID(id);
            return View(model);
        }
    }
}