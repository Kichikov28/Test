using System;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {

        Input();
        int type = int.Parse(Console.ReadLine());
        Console.Write($"Enter entry balance ");
        decimal balance = decimal.Parse(Console.ReadLine());
        switch (type)
        {
            case 1:
                CheckingAccount ck = new CheckingAccount();
                CheckingAccount(ck);
                break;
            case 2:
                SavingsAccount sacc = new SavingsAccount();
                SavingsAccount(sacc);
                break;
            case 3:
                CertificateOfDeposit cod = new CertificateOfDeposit();
                CertificateOfDeposit(cod);
                break;
            default:
                break;
        }

    }
    public static void CertificateOfDeposit(CertificateOfDeposit cod)
    {

        while (true)
        {
            Commands();
            Console.Write("Choose action: ");
            int cmd = int.Parse(Console.ReadLine());
            decimal amount;
            switch (cmd)
            {
                case 1:
                    Console.Write("Enter sum for deposit: ");
                    amount = decimal.Parse(Console.ReadLine());
                    cod.Deposit(amount);
                    break;
                case 2:
                    Console.Write("Enter sum for withdraw: ");
                    amount = decimal.Parse(Console.ReadLine());
                    cod.Withdraw(amount);
                    break;
                case 3:
                    Console.WriteLine("Withdrawing up to date... ");
                    cod.WithdrawOnMaturity();
                    break;
                case 4:
                    Console.WriteLine("Thanks");
                    Environment.Exit(0);
                    break;
            }

        }
    }
    public static void SavingsAccount(SavingsAccount sacc)
    {
        while (true)
        {
            Commands();
            Console.Write("Изберете действие: ");
            int cmd = int.Parse(Console.ReadLine());
            decimal amount;
            switch (cmd)
            {
                case 1:
                    Console.Write("Enter sum for deposit: ");
                    amount = decimal.Parse(Console.ReadLine());
                    sacc.Deposit(amount);
                    break;
                case 2:
                    Console.Write("Enter sum for withdraw: ");
                    amount = decimal.Parse(Console.ReadLine());
                    sacc.Withdraw(amount);
                    break;
                case 3:
                    Console.WriteLine("Calculating interest...");
                    sacc.CalculateInterest();
                    break;
                case 4:
                    Console.WriteLine("Thank you for choosing the bank manager!");
                    Environment.Exit(0);
                    break;
            }

        }
    }
    public static void CheckingAccount(CheckingAccount ck)
    {
        while (true)
        {
            Commands();
            Console.Write("Choose Action: ");
            int cmd = int.Parse(Console.ReadLine());
            decimal amount;
            switch (cmd)
            {
                case 1:
                    Console.Write("Enter sum for deposit: ");
                    amount = decimal.Parse(Console.ReadLine());
                    ck.Deposit(amount);
                    break;
                case 2:
                    Console.Write("Enter sum for withdraw: ");
                    amount = decimal.Parse(Console.ReadLine());
                    ck.Withdraw(amount);
                    break;
                case 3:
                    Console.WriteLine("Tax for service");
                    ck.DeductFees();
                    break;
                case 4:
                    Console.WriteLine("Thank you for choosing the bank manager!");
                    Environment.Exit(0);
                    break;
            }

        }
    }

    public static void Commands()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Select an action:");
        sb.AppendLine("1. Deposit");
        sb.AppendLine("2. Withdraw");
        sb.AppendLine("3. Interest calculation");
        sb.AppendLine("4. Exit");
        Console.WriteLine(sb.ToString());
    }
    private static void Input()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Welcome to the bank manager!");
        sb.AppendLine("Choose account");
        sb.AppendLine("1. Savings");
        sb.AppendLine("2. Checking");
        sb.AppendLine("3. CertificateOfDeposit");
        sb.Append("Enter number of the chosen acc: ");
        Console.WriteLine(sb.ToString());
    }
}

