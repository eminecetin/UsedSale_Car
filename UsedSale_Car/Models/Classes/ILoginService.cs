﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedSale_Car.Models.Classes
{
    interface ILoginService
    {
        bool HasAccount(string userName, string password);

        bool Login(string userName, string password);
        void Logout();
    }
}
