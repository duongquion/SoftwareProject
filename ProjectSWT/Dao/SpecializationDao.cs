using ProjectSWT.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectSWT.ViewModels;

namespace ProjectSWT.Dao
{
    public class SpecializationDao
    {
        ProjectSWTDbContext db = null;

        public SpecializationDao()
        {
            db = new ProjectSWTDbContext();
        }

        public List<Specialization> ListSpec()
        {
            return db.Specializations.Where(x => x.Status == true).OrderBy(x => x.CreateDate).ToList();
        }

        public List<Specialization> ListByCateSpecID (long categoryID)
        {
            return db.Specializations.Where(x => x.CateID == categoryID).ToList();
        }
    }
}