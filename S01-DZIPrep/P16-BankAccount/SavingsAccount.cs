using System;
using System.Collections.Generic;
using System.Text;

public class SavingsAccount : BankAccount
{
    public void CalculateInterest()
    {
        this.Balance *= 0.055m;
    }
}

