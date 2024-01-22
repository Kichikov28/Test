using System;
using System.Collections.Generic;
using System.Text;

public class User
{
    private string name;
    private double money;
    private readonly int stars;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Username must not be null or empty!");
            }
            name = value;
        }
    }
    public int Stars
    {
        get { return (int)Math.Floor(Money/100); }
    }

    public double Money
    {
        get { return money; }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("User's money cannot be less than 0!");
            }
            money = value;
        }
    }
    public  Computer Computer { get; set; }
}

