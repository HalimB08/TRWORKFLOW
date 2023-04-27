using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRWORKFLOW.Entities.Concrete;

namespace TRWORKFLOW.Business.Abstract
{
    public interface IUserManager <T> where T : class
    {
        List<User> GetAll();
        T? GetByID(int id);
        void AddUser(User user);
        void RemoveUser(User user);
        void UpdateUser(User user);        
    }
}
