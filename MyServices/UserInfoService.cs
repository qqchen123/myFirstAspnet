using EFModel;
using MyInterfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServices
{
    public class UserInfoService : IUserInfo
    {

        //public UserInfoService(DbContext context) { 
        //}

        public student GetUserInfo(int i)
        {
            //throw new NotImplementedException();

            using (UserInfo context = new UserInfo())
            {
                student student = context.student.FirstOrDefault();
                return student;
            }
        }
    }
}
