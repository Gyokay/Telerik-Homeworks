﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts.Interfaces
{
    interface IDepositable
    {
        void Deposit(decimal depositAmount);
    }
}
