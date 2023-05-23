using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRWORKFLOW.Business.Concrete;
using TRWORKFLOW.Entities.Concrete;

namespace TRWORKFLOW.Core.Concrete
{
    public class UserRegisterOperations
    {
        public void RegisterAdminUser(User user)
        {
            UserManager userManager = new UserManager();
            userManager.AddUser(user);
        }
    }
}
