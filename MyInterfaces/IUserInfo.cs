﻿using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces
{
    public interface IUserInfo
    {
        student GetUserInfo(int id);
    }
}
