using PagedList;
using ProjectSWT.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSWT.Dao
{
    public class UserDao
    {
        ProjectSWTDbContext db = null;

        public UserDao()
        {
            db = new ProjectSWTDbContext();
        }
        // Lấy dữ liệu
        public long Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }

        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.Username = entity.Username;
                user.Email = entity.Email;
                user.Phone = entity.Phone;
                user.CreateDate = DateTime.Now;
                user.Status = entity.Status;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }        
        }

        public bool Delete(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }           
        }

        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }

        // Tạo list người dùng
        public IEnumerable<User> GetAll(string searchString, int page, int pagesize)
        {
            IQueryable<User> model = db.Users;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Username.Contains(searchString) || x.Email.Contains(searchString)).OrderByDescending(x => x.CreateDate);
            }
            return model.OrderByDescending(x => x.CreateDate).ToPagedList(page, pagesize);
        }

        public bool ChangeStatus(long id)
        {
            var user = db.Users.Find(id);
            user.Status = !user.Status;
            db.SaveChanges();
            return user.Status;
        }

        //Lấy ID ng dùng
        public User GetByID(string username)
        {
            return db.Users.SingleOrDefault(x => x.Username == username);
        }
        //Xử lý Login
        public int Login(string username, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.Username == username);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Role == "admin")
                {
                    if (result.Status == false)
                    {
                        return -1;
                    }
                    else
                    {
                        if (result.Password == password)
                            return 1;
                        else
                            return -2;
                    }
                }
                else
                    return -3;
            }
        }
    }
}