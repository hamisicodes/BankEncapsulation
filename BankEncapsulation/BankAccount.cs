﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0;

        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
        }

        public double GetBalance() { return balance; }

    }
}
