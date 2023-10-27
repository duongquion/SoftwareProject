using ProjectSWT.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSWT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cateproductDao = new CateSpecializationDao();
            ViewBag.productList = cateproductDao.ListCateSpec();

            var programDao = new ProgramDao();
            ViewBag.programList = programDao.ListProgram();
            return View();
        }
    }
}