using ProjectSWT.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSWT.Dao
{
    public class CateSpecializationDao
    {
        ProjectSWTDbContext db = null;

        public CateSpecializationDao()
        {
            db = new ProjectSWTDbContext();
        }

        public List<CateSpecialization> ListCateSpec()
        {
            return db.CateSpecializations.Where(x => x.Status == true).OrderBy(x => x.CreateDate).ToList();
        }

        public CateSpecialization ViewDetail(long id)
        {
            return db.CateSpecializations.Find(id);
        }
    }
}