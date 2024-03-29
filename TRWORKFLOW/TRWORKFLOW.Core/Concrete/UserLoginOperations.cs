﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRWORKFLOW.Business.Concrete;
using TRWORKFLOW.Entities.Concrete;

namespace TRWORKFLOW.Core.Concrete
{
    public class UserLoginOperations
    {
        public bool IsItFirstTimeLogin()
        {
            UserManager userManager = new UserManager();
            return userManager.GetFirstData() == null ? true : false;
        }
        public User? GetUserLoginInfo(string userName, string Password)
        {
            UserManager userManager = new UserManager();
            return userManager.GetUserData(userName,Password);
        }
    }
}
