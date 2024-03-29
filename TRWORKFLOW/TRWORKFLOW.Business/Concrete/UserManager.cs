﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRWORKFLOW.Business.Abstract;
using TRWORKFLOW.DataAccess.Context;
using TRWORKFLOW.Entities.Concrete;
namespace TRWORKFLOW.Business.Concrete
{
    public class UserManager : IUserManager<User>
    {
        public void AddUser(User user)
        {
            using (TRWORKFLOWContext context = new TRWORKFLOWContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            using(TRWORKFLOWContext context = new TRWORKFLOWContext())
            {
                return context.Users.ToList();
            }             
        }
        public User? GetFirstData()
        {
            using (TRWORKFLOWContext context = new TRWORKFLOWContext())
            {
                User? user = context.Users.FirstOrDefault();
                return user;
            }
        }
        public User? GetUserData(string userName, string userPassword)
        {
            using (TRWORKFLOWContext context = new TRWORKFLOWContext())
            {
                User? user = context.Users.FirstOrDefault(u => u.UserName == userName && u.Password == userPassword);
                return user;
            }
        }
        public User? GetByID(int id)
        {
            using (TRWORKFLOWContext context = new TRWORKFLOWContext())
            {
                return context.Users.FirstOrDefault(p=>p.ID == id);
            }
        }

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
