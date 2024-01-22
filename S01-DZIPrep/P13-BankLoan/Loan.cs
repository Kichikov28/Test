using System;
using System.Collections.Generic;
using System.Text;

public abstract class Loan
{
    protected Loan(int interestRate, double amount)
    {
        this.InterestRate = interestRate;
        this.Amount = amount;
    }

    public int InterestRate { get; set; }
    public double Amount { get; set; }
}

