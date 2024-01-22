using System;
using System.Collections.Generic;
using System.Text;

public class CheckingAccount : BankAccount
{
    private const decimal fee = 3.00m;
    public void DeductFees()
    {
        this.Balance -= fee;
    }
}

