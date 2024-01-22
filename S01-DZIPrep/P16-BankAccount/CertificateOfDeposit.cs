using System;
using System.Collections.Generic;
using System.Text;

    public class CertificateOfDeposit:BankAccount
    {
    public DateTime MaturityDate { get; set; }
    private const decimal fee = 50m;
    public void WithdrawOnMaturity()
    {
        if (MaturityDate<DateTime.UtcNow)
        {
            this.Balance -= fee;
        }
    }
}

