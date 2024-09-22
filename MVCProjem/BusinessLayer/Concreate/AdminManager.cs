using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AdminAdd(Admin admin)
        {
            _adminDal.insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            _adminDal.update(admin);

        }

        public void AdminUpdate(Admin admin)
        {
            _adminDal.update(admin);
        }

        public Admin GetAdmin(string name, string password)
        {
            return _adminDal.Get(x => x.AdminUserName == name && x.AdminPassword == password);
        }

        public List<Admin> GetAll()
        {
            return _adminDal.List();
        }

        public Admin GetByID(int id)
        {
            return _adminDal.Get(x => x.AdminID == id);
        }

        public Admin GetRole(string username)
        {
            return _adminDal.Get(x => x.AdminUserName == username);
        }
    }

}
