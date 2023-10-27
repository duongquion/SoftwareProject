using ProjectSWT.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSWT.Dao
{
    public class ProgramDao
    {
        ProjectSWTDbContext db = null;

        public ProgramDao ()
        {
            db = new ProjectSWTDbContext ();
        }

        public List<Program> ListProgram()
        {
            return db.Programs.Where(x => x.Status == true).OrderBy(x => x.CreateDate).ToList();
        }
    }
}